
#define negEdgePin A5
#define pozEdgePin A7
#define pwmPin 3

int result[2] = {0,0};

void setup()
{
    Serial.begin(115200);
    pinMode(pozEdgePin,INPUT);
    pinMode(negEdgePin,INPUT);
    pinMode(pwmPin,OUTPUT);
    analogWrite(pwmPin,127);
}

void loop()
{
    result[0] = analogRead(pozEdgePin);
    result[1] = analogRead(negEdgePin);

    if(result[0] > 0)
    {
        Serial.println(result[0]);
    }
    else if(result[1] > 0)
    {
        Serial.println(-result[1]);
    }
    else
    {
        Serial.println("0"); 
    }
}
