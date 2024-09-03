#include <Servo.h>

#define pinservoA 4
#define pinservoB 5
#define pinservoC 6

#define IRA A1
#define IRB A2
#define IRC A3

char input;

Servo myservoA, myservoB, myservoC;

void setup()
{
  Serial.begin(9600);

  myservoA.attach(pinservoA); //dalam kota
  myservoB.attach(pinservoB); //luar kota
  myservoC.attach(pinservoC); //luar provinsi
  
  myservoA.write(90);
  myservoB.write(90);
  myservoC.write(90);
  
  Serial.println("Ready UNO");
}

void loop()
{
  if(Serial.available() > 0)
  {
    input = Serial.read();
    if (input == 'A'){dalamkota();}
    if (input == 'B'){luarkota();}
    if (input == 'C'){luarprov();}
    Serial.print("*");
  }
}

void dalamkota()
{
  myservoA.write(0); delay(1500);
  for (int a = 0; a <= 90; a++)
  {myservoA.write(a);delay(5);}
}

void luarkota()
{
  myservoB.write(0); delay(4000);
  for (int a = 0; a <= 90; a++)
  {myservoB.write(a);delay(5);}
}

void luarprov()
{
  myservoC.write(0); delay(7000);
  for (int a = 0; a <= 90; a++)
  {myservoC.write(a);delay(5);}
}
