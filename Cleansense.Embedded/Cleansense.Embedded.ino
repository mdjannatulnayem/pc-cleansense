#include <DHT.h>
#include <ArduinoJson.h>
#define MQ5PIN A0
#define GP2Y1 A3
#define PCVMPIN A6
#define DHTPIN 6
#define LEDPIN 5
#define BUZZER 3

DHT dht(DHTPIN,DHT11);
DynamicJsonDocument doc(256);

float gp2y_reading, calc_v;

int humidity;
int temperature;
int smoke = 0;
int vibration;
float dust;
int sampling = 280;
int delta_time = 40;
int sleep = 9680;
char cmd;

void setup() {
  dht.begin();
  Serial.begin(9600);
  pinMode(LEDPIN, OUTPUT);
  pinMode(BUZZER, OUTPUT);
}

void loop() {
  smoke = analogRead(MQ5PIN);
  vibration = analogRead(PCVMPIN);
  humidity = dht.readHumidity();
  temperature = dht.readTemperature();
  digitalWrite(LEDPIN, LOW);
  delayMicroseconds(sampling);
  gp2y_reading = analogRead(GP2Y1);
  delayMicroseconds(delta_time);
  digitalWrite(LEDPIN, HIGH);
  delayMicroseconds(sleep);
  calc_v = gp2y_reading * (5.0 / 1024);
  dust =  170.0 * calc_v - 0.1;
  doc["t"] = temperature;
  doc["moist"] = humidity;
  doc["vb"] = vibration;
  doc["smoke"] = smoke;
  doc["dust"] = (int)dust;
  serializeJson(doc,Serial);
  Serial.println();
  cmd = Serial.read();
  if(cmd == 'A'){
    digitalWrite(BUZZER,HIGH); 
  }
  else digitalWrite(BUZZER,LOW);
  delay(500);
}
