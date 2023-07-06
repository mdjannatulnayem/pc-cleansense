#include <DHT.h>

#define DHTPIN 13
#define PCVMPIN A0
#define MQ5PIN A1
#define GP2Y1PIN A2
#define LEDPIN 2

DHT dht(DHTPIN,DHT11);

int humidity;
int temperature;
int vibration;
float dust;
int smoke;
int sampling = 280;
int delta_time = 40;
int sleep = 9680;

float gp2y_reading,calc_v;

void setup() 
{
  Serial.begin(9600);
  dht.begin();
  pinMode(LEDPIN,OUTPUT);
}

void loop() 
{
  humidity = dht.readHumidity();
  temperature = dht.readTemperature();
  vibration = analogRead(PCVMPIN);
  smoke = analogRead(MQ5PIN);
  /*GP2Y1 specific code follows*/
  digitalWrite(LEDPIN,LOW);
  delayMicroseconds(sampling);
  gp2y_reading = analogRead(GP2Y1PIN);
  delayMicroseconds(delta_time);
  digitalWrite(LEDPIN,HIGH);
  delayMicroseconds(sleep);
  calc_v = gp2y_reading * (5.0 / 1024.0);
  dust =  170.0 * calc_v - 0.1;
}
