namespace freeScope
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-0.5D, "1,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-1D, "1,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-1.5D, "2,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-2D, "1.5,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-2.5D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trigValBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.riseDerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fallDerBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trigTolBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.derTolBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minTimeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minVoltsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maxVoltsBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sampleSizeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timeIntervalBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.voltsIntervalBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maxValBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.minValBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.AxisX.Interval = 0.5D;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Maximum = 0D;
            chartArea1.AxisX.Minimum = -2.5D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "ms";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.Interval = 5D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Interval = 5D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.AxisY.MinorGrid.IntervalOffset = double.NaN;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "v";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(220, 82);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Color = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.White;
            dataPoint1.MarkerSize = 10;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1080, 610);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trigValBox
            // 
            this.trigValBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.trigValBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigValBox.ForeColor = System.Drawing.Color.Red;
            this.trigValBox.Location = new System.Drawing.Point(50, 125);
            this.trigValBox.Name = "trigValBox";
            this.trigValBox.Size = new System.Drawing.Size(120, 33);
            this.trigValBox.TabIndex = 2;
            this.trigValBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trigValBox.TextChanged += new System.EventHandler(this.trigValBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(50, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trigger value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(50, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rising edge derivative";
            // 
            // riseDerBox
            // 
            this.riseDerBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.riseDerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.riseDerBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riseDerBox.ForeColor = System.Drawing.Color.Red;
            this.riseDerBox.Location = new System.Drawing.Point(50, 315);
            this.riseDerBox.Name = "riseDerBox";
            this.riseDerBox.ReadOnly = true;
            this.riseDerBox.Size = new System.Drawing.Size(120, 33);
            this.riseDerBox.TabIndex = 4;
            this.riseDerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(50, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Falling edge derivative";
            // 
            // fallDerBox
            // 
            this.fallDerBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.fallDerBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fallDerBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallDerBox.ForeColor = System.Drawing.Color.Red;
            this.fallDerBox.Location = new System.Drawing.Point(50, 410);
            this.fallDerBox.Name = "fallDerBox";
            this.fallDerBox.ReadOnly = true;
            this.fallDerBox.Size = new System.Drawing.Size(120, 33);
            this.fallDerBox.TabIndex = 6;
            this.fallDerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(1312, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wave period";
            // 
            // periodBox
            // 
            this.periodBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.periodBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.periodBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodBox.ForeColor = System.Drawing.Color.Red;
            this.periodBox.Location = new System.Drawing.Point(1312, 125);
            this.periodBox.Name = "periodBox";
            this.periodBox.ReadOnly = true;
            this.periodBox.Size = new System.Drawing.Size(121, 33);
            this.periodBox.TabIndex = 8;
            this.periodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(50, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trigger tolerance";
            // 
            // trigTolBox
            // 
            this.trigTolBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.trigTolBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigTolBox.ForeColor = System.Drawing.Color.Red;
            this.trigTolBox.Location = new System.Drawing.Point(50, 220);
            this.trigTolBox.Name = "trigTolBox";
            this.trigTolBox.Size = new System.Drawing.Size(120, 33);
            this.trigTolBox.TabIndex = 10;
            this.trigTolBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trigTolBox.TextChanged += new System.EventHandler(this.trigTolBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(50, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Derivative tolerance";
            // 
            // derTolBox
            // 
            this.derTolBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.derTolBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derTolBox.ForeColor = System.Drawing.Color.Red;
            this.derTolBox.Location = new System.Drawing.Point(50, 505);
            this.derTolBox.Name = "derTolBox";
            this.derTolBox.Size = new System.Drawing.Size(120, 33);
            this.derTolBox.TabIndex = 12;
            this.derTolBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.derTolBox.TextChanged += new System.EventHandler(this.derTolBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(260, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min time";
            // 
            // minTimeBox
            // 
            this.minTimeBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.minTimeBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTimeBox.ForeColor = System.Drawing.Color.Red;
            this.minTimeBox.Location = new System.Drawing.Point(260, 715);
            this.minTimeBox.Name = "minTimeBox";
            this.minTimeBox.Size = new System.Drawing.Size(120, 33);
            this.minTimeBox.TabIndex = 14;
            this.minTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minTimeBox.TextChanged += new System.EventHandler(this.minTimeBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(600, 685);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Min volts";
            // 
            // minVoltsBox
            // 
            this.minVoltsBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.minVoltsBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minVoltsBox.ForeColor = System.Drawing.Color.Red;
            this.minVoltsBox.Location = new System.Drawing.Point(600, 715);
            this.minVoltsBox.Name = "minVoltsBox";
            this.minVoltsBox.Size = new System.Drawing.Size(120, 33);
            this.minVoltsBox.TabIndex = 16;
            this.minVoltsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minVoltsBox.TextChanged += new System.EventHandler(this.minVoltsBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(770, 685);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Max volts";
            // 
            // maxVoltsBox
            // 
            this.maxVoltsBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.maxVoltsBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVoltsBox.ForeColor = System.Drawing.Color.Red;
            this.maxVoltsBox.Location = new System.Drawing.Point(770, 715);
            this.maxVoltsBox.Name = "maxVoltsBox";
            this.maxVoltsBox.Size = new System.Drawing.Size(120, 33);
            this.maxVoltsBox.TabIndex = 18;
            this.maxVoltsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxVoltsBox.TextChanged += new System.EventHandler(this.maxVoltsBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(1110, 685);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sample size";
            // 
            // sampleSizeBox
            // 
            this.sampleSizeBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.sampleSizeBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleSizeBox.ForeColor = System.Drawing.Color.Red;
            this.sampleSizeBox.Location = new System.Drawing.Point(1110, 715);
            this.sampleSizeBox.Name = "sampleSizeBox";
            this.sampleSizeBox.Size = new System.Drawing.Size(120, 33);
            this.sampleSizeBox.TabIndex = 20;
            this.sampleSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sampleSizeBox.TextChanged += new System.EventHandler(this.sampleSizeBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(430, 685);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Time interval";
            // 
            // timeIntervalBox
            // 
            this.timeIntervalBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.timeIntervalBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIntervalBox.ForeColor = System.Drawing.Color.Red;
            this.timeIntervalBox.Location = new System.Drawing.Point(430, 715);
            this.timeIntervalBox.Name = "timeIntervalBox";
            this.timeIntervalBox.Size = new System.Drawing.Size(120, 33);
            this.timeIntervalBox.TabIndex = 22;
            this.timeIntervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeIntervalBox.TextChanged += new System.EventHandler(this.timeIntervalBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(940, 685);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Volts interval";
            // 
            // voltsIntervalBox
            // 
            this.voltsIntervalBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.voltsIntervalBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltsIntervalBox.ForeColor = System.Drawing.Color.Red;
            this.voltsIntervalBox.Location = new System.Drawing.Point(940, 715);
            this.voltsIntervalBox.Name = "voltsIntervalBox";
            this.voltsIntervalBox.Size = new System.Drawing.Size(120, 33);
            this.voltsIntervalBox.TabIndex = 24;
            this.voltsIntervalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.voltsIntervalBox.TextChanged += new System.EventHandler(this.voltsIntervalBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(1312, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Max Value";
            // 
            // maxValBox
            // 
            this.maxValBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.maxValBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxValBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxValBox.ForeColor = System.Drawing.Color.Red;
            this.maxValBox.Location = new System.Drawing.Point(1312, 220);
            this.maxValBox.Name = "maxValBox";
            this.maxValBox.ReadOnly = true;
            this.maxValBox.Size = new System.Drawing.Size(121, 33);
            this.maxValBox.TabIndex = 26;
            this.maxValBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(1312, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 21);
            this.label14.TabIndex = 29;
            this.label14.Text = "Min Value";
            // 
            // minValBox
            // 
            this.minValBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.minValBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.minValBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minValBox.ForeColor = System.Drawing.Color.Red;
            this.minValBox.Location = new System.Drawing.Point(1312, 315);
            this.minValBox.Name = "minValBox";
            this.minValBox.ReadOnly = true;
            this.minValBox.Size = new System.Drawing.Size(121, 33);
            this.minValBox.TabIndex = 28;
            this.minValBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DtrEnable = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Black;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(370, 40);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 25);
            this.refreshBtn.TabIndex = 30;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.Color.Black;
            this.portBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portBox.ForeColor = System.Drawing.Color.White;
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(470, 43);
            this.portBox.MaximumSize = new System.Drawing.Size(90, 0);
            this.portBox.MinimumSize = new System.Drawing.Size(90, 0);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(90, 21);
            this.portBox.TabIndex = 31;
            // 
            // openBtn
            // 
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Location = new System.Drawing.Point(585, 40);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 25);
            this.openBtn.TabIndex = 32;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.BackColor = System.Drawing.Color.Red;
            this.connectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.connectionLabel.Location = new System.Drawing.Point(1155, 60);
            this.connectionLabel.MaximumSize = new System.Drawing.Size(100, 15);
            this.connectionLabel.MinimumSize = new System.Drawing.Size(100, 15);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(100, 15);
            this.connectionLabel.TabIndex = 33;
            this.connectionLabel.Text = "Disconected";
            this.connectionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(185, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "v";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(185, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 23);
            this.label16.TabIndex = 35;
            this.label16.Text = "v";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(185, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 23);
            this.label17.TabIndex = 36;
            this.label17.Text = "dv/dt";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(185, 416);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 23);
            this.label18.TabIndex = 37;
            this.label18.Text = "dv/dt";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Location = new System.Drawing.Point(185, 511);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 23);
            this.label19.TabIndex = 38;
            this.label19.Text = "dv/dt";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label20.Location = new System.Drawing.Point(1442, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 23);
            this.label20.TabIndex = 39;
            this.label20.Text = "ms";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label21.Location = new System.Drawing.Point(1442, 225);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 23);
            this.label21.TabIndex = 40;
            this.label21.Text = "v";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(1442, 321);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 23);
            this.label22.TabIndex = 41;
            this.label22.Text = "v";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(1312, 410);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(120, 45);
            this.trackBar1.TabIndex = 42;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label23.Location = new System.Drawing.Point(1312, 380);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 21);
            this.label23.TabIndex = 43;
            this.label23.Text = "Point Size";
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(685, 40);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 25);
            this.clearButton.TabIndex = 44;
            this.clearButton.Text = "Clear Buffer";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1524, 781);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.minValBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maxValBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.voltsIntervalBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timeIntervalBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sampleSizeBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxVoltsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.minVoltsBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minTimeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.derTolBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trigTolBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fallDerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.riseDerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trigValBox);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1540, 820);
            this.MinimumSize = new System.Drawing.Size(1540, 820);
            this.Name = "Form1";
            this.Text = "Free Scope";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox trigValBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox riseDerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fallDerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trigTolBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox derTolBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minTimeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minVoltsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox maxVoltsBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sampleSizeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timeIntervalBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox voltsIntervalBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox maxValBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox minValBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button clearButton;
    }
}

