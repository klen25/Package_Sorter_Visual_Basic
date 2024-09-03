#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 53
#define RST_PIN 5
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;

#define buzz 7
#define IRbrg A0
#define pjg16 2
#define bloktujuan 32

#define relay 8

byte baca_tujuan[pjg16];
boolean barang, done;
int IRstate, lastIRstate, timer = 0;
char input;

void setup()
{
  Serial.begin(9600);
  Serial1.begin(9600);
  Serial3.begin(9600);
  SPI.begin();

  barang = false;
  done = false;
  
  pinMode(IRbrg, INPUT);
  pinMode(buzz, OUTPUT);
  digitalWrite(buzz, LOW);
  pinMode(relay, OUTPUT);
  
  mfrc522.PCD_Init();
  Serial.println("Ready Mega");
}

void loop()
{
  IRstate = digitalRead(IRbrg);
  if(IRstate == LOW)
  {
    baca_tujuan[0] = 0;
    baca_tujuan[1] = 0;
    timer = 0;
    barang = true;
  }
  else
  {
    delay(100); timer=+1;
    if(timer == 300)
    {
      conveyorstop();
    }
    else
    {
      conveyorjalan();
    }
  }
  
  if(Serial1.available() > 0)
  {
    input = Serial1.read();
    Serial.print(baca_tujuan[1]); Serial.print(input);
//    if (input == '*')
//    {
      Serial3.print(baca_tujuan[1]);
      Serial.print(baca_tujuan[1]); Serial.print(input);
//    }
  }
  
  if (barang == true)
  {
    conveyorstop();
//    delay(300);
    dataRFID();
    readBlock(bloktujuan, baca_tujuan);
    Serial.print(baca_tujuan[0]);Serial.println(baca_tujuan[1]);
    if(baca_tujuan[0] == 48)
    {
      Serial1.print("A");
    }
    else if(baca_tujuan[0] == 49)
    {
      Serial1.print("B");
    }
    else if(baca_tujuan[0] == 50)
    {
      Serial1.print("C");
    }
    else
    {
      nokia();
      //digitalWrite(buzz, HIGH); delay(1000); digitalWrite(buzz, LOW);
      //Serial1.print("X");
    }
    conveyorjalan();

    mfrc522.PICC_HaltA();
    mfrc522.PCD_StopCrypto1();
    barang = false; delay(1000);
  }
}

void nokia()
{
  digitalWrite(buzz, HIGH); delay(100); digitalWrite(buzz, LOW);delay(100);
  digitalWrite(buzz, HIGH); delay(100); digitalWrite(buzz, LOW);delay(100);
  digitalWrite(buzz, HIGH); delay(100); digitalWrite(buzz, LOW);delay(250);
  
  digitalWrite(buzz, HIGH); delay(250); digitalWrite(buzz, LOW);delay(200);
  digitalWrite(buzz, HIGH); delay(200); digitalWrite(buzz, LOW);delay(250);  
  
  digitalWrite(buzz, HIGH); delay(100); digitalWrite(buzz, LOW);delay(100);
  digitalWrite(buzz, HIGH); delay(100); digitalWrite(buzz, LOW);delay(100);
  digitalWrite(buzz, HIGH); delay(100); digitalWrite(buzz, LOW);
}

void conveyorjalan()
{
  digitalWrite(relay, LOW);
}

void conveyorstop()
{
  digitalWrite(relay, HIGH);
}

uint8_t dataRFID()
{
  for (byte i = 0; i < 6; i++) { key.keyByte[i] = 0xFF; }
  if (!mfrc522.PICC_IsNewCardPresent())
  {
//    Serial.println("Not New Card");
    return 0;
  }
  if(!mfrc522.PICC_ReadCardSerial())
  {
//    Serial.println("Error Read RFID");
    return 0;
  }
  return 1;
}

int readBlock(int blockNumber,byte arrayAddress[]) 
{
  int largestModulo4Number = blockNumber / 4 * 4;
  int trailerBlock = largestModulo4Number + 3;
  MFRC522::StatusCode status;
  //Serial.setTimeout(20000L) ;

  status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, trailerBlock, &key, &(mfrc522.uid));
  if (status != MFRC522::STATUS_OK)
  {
    Serial.print("Failed: ");
    Serial.println(mfrc522.GetStatusCodeName(status));
    return 3;
  }

  byte buffersize = 18;
  status = mfrc522.MIFARE_Read(blockNumber, arrayAddress, &buffersize);
  if (status != MFRC522::STATUS_OK)
  {
    Serial.println("Read RFID failed: ");
    return 4;
  }
}
