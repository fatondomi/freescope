using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freeScope
{
    public partial class Form1 : Form
    {
        private double millis = 0;

        private int seriesIndex = 0;
        private int seriesLength = 100;
        private int sLenMtwo = 98;     // series length minus 1

        //the series of points is stored in two lists ptsX & ptsY
        private List<double> ptsX = new List<double> { };
        private List<double> ptsY = new List<double> { };

        private bool seriesRepeats = false;
        private double seriesPeriod = 0;

        private double triggerValue = 5.5;
        //Math.Floor((8 * Math.Sin(0.1 * Math.PI)) * 10000)/10000;

        private double prevValue = 0;  // used for calculating the current derivative
        private double prevTime = 0;   // used for calculating the current derivative

        private double currentDerivative = 0; //used for finding the series period
        private double risingEdgeTriggerDerivative = 0;  //used for finding the series period
        private double fallingEdgeTriggerDerivative = 0; //used for finding the series period

        private double risingEdgeTimeRef = 0;  // time since last triggered
        private double fallingEdgeTimeRef = 0; // time since last triggered

        private bool triggered = false; //is the trigger value found
        private double triggerTolerance = 0.005;
        private double derivativeTolerance = 0.002;

        private double lastDrawn = 0; //last tims since the chart was updated

        private double maxValue = 0;
        private double minValue = 0;

        public Form1()
        {
            InitializeComponent();

            chart1.BackColor = Color.Black;

            chart1.ChartAreas[0].BackColor = Color.Black;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;

            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;

            chart1.ChartAreas[0].AxisX.Title = "ms";
            chart1.ChartAreas[0].AxisY.Title = "v";

            chart1.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.TitleForeColor = Color.White;

            chart1.ChartAreas[0].AxisX.Maximum = 0;
            chart1.ChartAreas[0].AxisX.Minimum = -30;
            chart1.ChartAreas[0].AxisY.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Minimum = -10;
            
            chart1.ChartAreas[0].AxisY.Interval = 5;
            chart1.ChartAreas[0].AxisX.Interval = 5;

            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].MarkerSize = 5;
            //chart1.Series[0].BorderWidth = 2;

            // trigger line
            chart1.Series[1].Points.Clear();
            chart1.Series[1].Color = Color.Aqua;
            chart1.Series[1].MarkerSize = 4;
            chart1.Series[1].Points.AddXY(chart1.ChartAreas[0].AxisX.Minimum, triggerValue);
            chart1.Series[1].Points.AddXY(chart1.ChartAreas[0].AxisX.Maximum, triggerValue);

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < seriesLength; i++)
            {
                ptsX.Add(0);
                ptsY.Add(0);
                chart1.Series[0].Points.AddXY(0, 0);
            }


            trigValBox.Text = triggerValue.ToString();
            trigTolBox.Text = triggerTolerance.ToString();
            derTolBox.Text = derivativeTolerance.ToString();
            minTimeBox.Text = chart1.ChartAreas[0].AxisX.Minimum.ToString();
            timeIntervalBox.Text = chart1.ChartAreas[0].AxisX.Interval.ToString();
            minVoltsBox.Text = chart1.ChartAreas[0].AxisY.Minimum.ToString();
            maxVoltsBox.Text = chart1.ChartAreas[0].AxisY.Maximum.ToString();
            voltsIntervalBox.Text = chart1.ChartAreas[0].AxisY.Interval.ToString();
            sampleSizeBox.Text = ptsX.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                // refreshing the time variable millis and reseting trigger to false
                millis += 0.3333;
                
                // getting new x point value
                // getting new y point value
                //ptsY[seriesIndex] = Math.Floor((8 * Math.Sin(0.01*millis * Math.PI)) * 10000) / 10000;
                try
                {
                    ptsY[seriesIndex] = (10 * Convert.ToDouble(serialPort1.ReadLine())) / 1023;
                    ptsX[seriesIndex] = millis;
                }
                catch
                {
                    return;
                }

                triggered = false;

                // refreshing the index of where the new point will be written (0,1,2...sLength-1,0,1,2...)
                if (seriesIndex < sLenMtwo)
                {
                    seriesIndex++;
                }
                else {
                    seriesIndex = 0;
                    maxValBox.Text = (Math.Floor(maxValue * 10000) / 10000).ToString();
                    minValBox.Text = (Math.Floor(minValue * 10000) / 10000).ToString();
                    maxValue = 0;
                    minValue = 0;
                }

                maxValue = (maxValue < ptsY[seriesIndex]) ? ptsY[seriesIndex] : maxValue;
                minValue = (minValue > ptsY[seriesIndex]) ? ptsY[seriesIndex] : minValue;

                //  current derivative = delta y value / delta time
                currentDerivative = Math.Floor(((ptsY[seriesIndex] - prevValue) / (millis - prevTime)) * 10000) / 10000;
                // prev time is not used for anything else so it becomes millis right here together with prevValue
                prevTime = millis;
                prevValue = ptsY[seriesIndex];

                if (
                    (ptsY[seriesIndex] + triggerTolerance >= triggerValue)
                  &&(ptsY[seriesIndex] - triggerTolerance < triggerValue)
                    )
                {   //cheking if y value is within trigger zone

                    // We need to know when the trigger happens to calculate the period of
                    // the periodic wave (if it is periodic) so that we know when to refresh the chart
                    // in order for us to achieve a standing wave
                    triggered = true;

                    // nailing down the trigger value so that we trigger in the same place every cycle
                    triggerValue = ptsY[seriesIndex];
                    trigValBox.Text = (Math.Floor(ptsY[seriesIndex]*10000)/10000).ToString();

                    if (
                        ((currentDerivative + derivativeTolerance) >= risingEdgeTriggerDerivative)
                     && ((currentDerivative - derivativeTolerance) < risingEdgeTriggerDerivative)
                        )
                    {   // checking that the derivative at this trigger is equal to the derivative we want
                        // we can trigger at most two times at any periodiv wave
                        // once during the rising edge and once during the falling edge
                        // the period of the wave is calculated by measuring the time intervale
                        // between two rising edges or between two falling edges.
                        // for this purpose we need to store time references to previous rising/falling edges
                        // that is why the risingEdgeTimeRef & fallingEdgeTimeRef exists
                        seriesRepeats = true;
                        seriesPeriod = Math.Floor((millis - risingEdgeTimeRef) * 10000) / 10000;
                        periodBox.Text = Math.Round(seriesPeriod, 3).ToString();
                        risingEdgeTimeRef = millis;
                        //changing the color of the text boxes to notify that we are consistingly hitting
                        // the same trigger with the same derivative
                        riseDerBox.BackColor = Color.Red;
                        riseDerBox.ForeColor = Color.Black;
                        fallDerBox.BackColor = Color.Black;
                        fallDerBox.ForeColor = Color.Red;
                    }
                    else if (
                             ((currentDerivative + derivativeTolerance) >= fallingEdgeTriggerDerivative)
                          && ((currentDerivative - derivativeTolerance) < fallingEdgeTriggerDerivative)
                             )
                    {
                        seriesRepeats = true;
                        seriesPeriod = Math.Floor((millis - fallingEdgeTimeRef)*10000)/10000;
                        periodBox.Text = Math.Round(seriesPeriod,3).ToString();
                        fallingEdgeTimeRef = millis;
                        //changing the color of the text boxes to notify that we are consistingly hitting
                        // the same trigger with the same derivative
                        riseDerBox.BackColor = Color.Black;
                        riseDerBox.ForeColor = Color.Red;
                        fallDerBox.BackColor = Color.Red;
                        fallDerBox.ForeColor = Color.Black;
                    }
                    else
                    {// when the derivative doesn't match we set it up for the next trigger so that perhaps 
                     // when the next trgigger comes it will be the same
                        risingEdgeTriggerDerivative = (currentDerivative > 0) ? currentDerivative : risingEdgeTriggerDerivative;
                        fallingEdgeTriggerDerivative = (currentDerivative < 0) ? currentDerivative : fallingEdgeTriggerDerivative;
                        riseDerBox.Text = risingEdgeTriggerDerivative.ToString();
                        fallDerBox.Text = fallingEdgeTriggerDerivative.ToString();
                        riseDerBox.BackColor = Color.Black;
                        riseDerBox.ForeColor = Color.Red;
                        fallDerBox.BackColor = Color.Black;
                        fallDerBox.ForeColor = Color.Red;
                    }
                }

                if (!seriesRepeats)
                {
                    for (int i = 0; i < ptsX.Count; i++)
                    {
                        chart1.Series[0].Points[i].SetValueXY(ptsX[i] - millis, ptsY[i]);
                    }
                    chart1.Refresh();
                }
                else
                {
                    if (triggered && ((millis - lastDrawn) >= seriesPeriod))
                    {
                        for (int i = 0; i < ptsX.Count; i++)
                        {
                            chart1.Series[0].Points[i].SetValueXY(ptsX[i] - millis, ptsY[i]);
                        }
                        chart1.Refresh();

                        lastDrawn = millis;
                    }
                }

                if ((millis - lastDrawn) > seriesPeriod)
                {// if don't trigger then eventully the curren time - last drawn time
                 //  will out grow our series period and that means that the period is defective
                 // or the trigger is defective or simply the signal wave is not periodic
                    seriesRepeats = false;
                    periodBox.Text = "0";
                }
            }
        }

        private void trigValBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                triggerValue = Convert.ToDouble(trigValBox.Text);
                chart1.Series[1].Points[0].SetValueXY(chart1.ChartAreas[0].AxisX.Minimum, triggerValue);
                chart1.Series[1].Points[1].SetValueXY(chart1.ChartAreas[0].AxisX.Maximum, triggerValue);
            }
            catch
            {
            }
        }

        private void trigTolBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                triggerTolerance = Convert.ToDouble(trigTolBox.Text);
            }
            catch
            {
            }
        }

        private void derTolBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                derivativeTolerance = Convert.ToDouble(derTolBox.Text);
            }
            catch
            {
            }
        }

        private void minTimeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(minTimeBox.Text);

                chart1.Series[1].Points.Clear();
                chart1.Series[1].Points.AddXY(chart1.ChartAreas[0].AxisX.Minimum, triggerValue);
                chart1.Series[1].Points.AddXY(chart1.ChartAreas[0].AxisX.Maximum, triggerValue);

                chart1.Refresh();
            }
            catch
            {
            }
        }

        private void timeIntervalBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisX.Interval = Convert.ToDouble(timeIntervalBox.Text);
                chart1.Refresh();
            }
            catch
            {
            }
        }

        private void minVoltsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(minVoltsBox.Text);
                chart1.Refresh();
            }
            catch
            {
            }
        }

        private void maxVoltsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(maxVoltsBox.Text);
                chart1.Refresh();
            }
            catch
            {
            }
        }

        private void voltsIntervalBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.ChartAreas[0].AxisY.Interval = Convert.ToDouble(voltsIntervalBox.Text);
                chart1.Refresh();
            }
            catch
            {
            }
        }

        private void sampleSizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                seriesLength = Convert.ToInt32(sampleSizeBox.Text);
                seriesLength = (seriesLength > 5) ? seriesLength : 5;
                sLenMtwo = seriesLength - 2;
                seriesIndex = 0;
                seriesRepeats = false;

                prevValue = 0;
                prevTime = 0;
                lastDrawn = 0;

                seriesPeriod = 0;
                periodBox.Text = "0";

                risingEdgeTimeRef = 0;
                risingEdgeTriggerDerivative = 0;
                riseDerBox.Text = "";

                fallingEdgeTimeRef = 0;
                fallingEdgeTriggerDerivative = 0;
                fallDerBox.Text = "";

                riseDerBox.BackColor = Color.Black;
                riseDerBox.ForeColor = Color.Red;
                fallDerBox.BackColor = Color.Black;
                fallDerBox.ForeColor = Color.Red;

                currentDerivative = 0;

                ptsX.Clear();
                ptsY.Clear();
                chart1.Series[0].Points.Clear();

                for (int i = 0; i < seriesLength; i++)
                {
                    ptsX.Add(0);
                    ptsY.Add(0);
                    chart1.Series[0].Points.AddXY(0, 0);
                }
            }
            catch
            {
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            portBox.Items.Clear();

            foreach (String port in System.IO.Ports.SerialPort.GetPortNames())
            {
                portBox.Items.Add(port);
            }

            if (portBox.Items.Count > 0)
            {
                portBox.SelectedIndex = 0;
            }
            else
            {
                portBox.Items.Add(" ");
                portBox.SelectedIndex = 0;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (openBtn.Text == "Open" && (portBox.Items.Count > 0))
            {
                bool portExists = false;

                foreach (String port in System.IO.Ports.SerialPort.GetPortNames())
                {
                    portExists = (port == portBox.SelectedItem.ToString()) ? true : portExists;
                }

                if (portExists)
                {
                    try
                    {
                        serialPort1.PortName = portBox.SelectedItem.ToString();
                        serialPort1.Open();
                        connectionLabel.Text = "Connected";
                        connectionLabel.BackColor = Color.Green;
                        openBtn.Text = "Close";
                    }
                    catch
                    {
                    }
                }
                else
                {
                    portBox.Items.Clear();

                    foreach (String port in System.IO.Ports.SerialPort.GetPortNames())
                    {
                        portBox.Items.Add(port);
                    }

                    if (portBox.Items.Count > 0)
                    {
                        portBox.SelectedIndex = 0;
                    }
                    else
                    {
                        portBox.Items.Add(" ");
                        portBox.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                connectionLabel.Text = "Disconnected";
                connectionLabel.BackColor = Color.Red;
                openBtn.Text = "Open";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chart1.Series[0].MarkerSize = trackBar1.Value;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
            }
        }
    }
}
