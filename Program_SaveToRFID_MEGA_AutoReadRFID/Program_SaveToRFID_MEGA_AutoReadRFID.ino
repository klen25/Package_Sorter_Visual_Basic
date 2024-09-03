/* ———————————————————————————
* Inisialisasi PIN RFID - Arduino Mega 2560
* Reset      5 RST
* SPI SS    53 SDA
* SPI MOSI  52 MOSI
* SPI MISO  51 MISO
* SPI SCK   50 SCK
* 
* Inisialisasi PIN RFID - Arduino UNO
* Reset      9 RST
* SPI SS    10 SDA
* SPI MOSI  11 MOSI
* SPI MISO  12 MISO
* SPI SCK   13 SCK
*————————————————————————————
*/
#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 53
#define RST_PIN 5
MFRC522 mfrc522(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
byte nuidPICC[3]; // Init array that will store new NUID 
bool IDRIFID;

String strdata, data[7];
String IDPaket, Tujuan, DataPengirim, DataPenerimaPaket;

#define pjg16 16
#define pjg17 17

/*------------------ Alamat Penyimpanan RFID */
int id_brg    = 62; //16byte

int nama_pgm1 = 61; int nama_pgm2 = 60; //32byte
int alam_pgm1 = 58; int alam_pgm2 = 57; //32byte
int hp_pgm    = 56; //16byte

int nama_pnm1 = 54; int nama_pnm2 = 53; //32byte
int alam_pnm1 = 50; int alam_pnm2 = 49; int alam_pnm3 = 48;
int alam_pnm4 = 46; int alam_pnm5 = 45; int alam_pnm6 = 44; //96byte
int keca_pnm1 = 42; int keca_pnm2 = 41; //32byte
int kota_pnm1 = 40; int kota_pnm2 = 38; //32byte
int prov_pnm1 = 37; int prov_pnm2 = 36; //32byte
int kode_pnm  = 34; //16byte
int hp_pnm    = 33; //16byte
int tujuan = 32;

/*------------------ Variabel Penyimpanan RFID */
byte data_id_brg[pjg16]    = {32,32,32,32,32,32,32,32,32,32,32,32,32,32,32,32};
byte data_nama_pgm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_nama_pgm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pgm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pgm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_hp_pgm[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

byte data_nama_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_nama_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pnm3[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pnm4[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pnm5[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_alam_pnm6[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_keca_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_keca_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_kota_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_kota_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_prov_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_prov_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_kode_pnm[pjg16]  = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_hp_pnm[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte data_tujuan[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

//*------------------ Variabel Pembaca RFID */
byte baca_id_brg[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_nama_pgm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_nama_pgm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pgm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pgm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_hp_pgm[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

byte baca_nama_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_nama_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pnm3[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pnm4[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pnm5[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_alam_pnm6[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_keca_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_keca_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_kota_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_kota_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_prov_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_prov_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_kode_pnm[pjg16]  = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_hp_pnm[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
byte baca_tujuan[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

void setup()
{
  Serial.begin(9600);
  SPI.begin();
  mfrc522.PCD_Init();
  Serial.println("Ready");
  for (byte i = 0; i < 6; i++) { key.keyByte[i] = 0xFF; }
}

void loop()
{
  if(Serial.available())
  {
    delay(1);
    while (Serial.available())
    {
      if (Serial.available() >0) 
      {
        strdata = Serial.readStringUntil('.');
      }
    }
  }
  else
  {
     cekRFID();
  }
  
  if (strdata.startsWith("*"))
    {
      cekdata();
      delay(100);
      savetoRFID();
    }
    if (strdata.startsWith("@"))
    {
      Serial.print("ID|");
      cetakIDRFID();
      Serial.print("|#");
    }
    if (strdata.startsWith("&"))
    {
      delay(100);
      ambilRFID();
      delay(500);
      Serial.print("#");
    }
    strdata="";
    delay(10);
}

//=====================================================
void printHex(byte *buffer, byte bufferSize)
{
  for (byte i = 0; i < bufferSize; i++)
  {
    Serial.print(buffer[i] < 0x10 ? "0" : "");
    Serial.print(buffer[i], HEX);
  }
}

//=====================================================
void cetakIDRFID()
{  
    Serial.print("ID|");
    String content = "";
    byte letter;
    for (byte i = 0; i < mfrc522.uid.size; i++) 
    {
       Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "");
       Serial.print(mfrc522.uid.uidByte[i], HEX);
       content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : ""));
       content.concat(String(mfrc522.uid.uidByte[i], HEX));
    }
    Serial.print("|#");
}

void cekRFID()
{
  if (!mfrc522.PICC_IsNewCardPresent()) return;
  if (!mfrc522.PICC_ReadCardSerial()) return;
  else cetakIDRFID();
}

void cekdata()
{
  cleardata();
  IDPaket = "";
  DataPenerimaPaket = "";
  DataPengirim = "";
  Tujuan = "";
  
  int j=0;
  data[j]="";
  
//  Serial.print("Data Masuk : "); Serial.print(strdata); Serial.println();
  delay(100);
  for(int i = 1; i < strdata.length(); i++)
  {
    if ((strdata[i] == '#'))
    {
      j++;
      data[j]="";
    }
    else
    {
      data[j] = data[j] + strdata[i];
    }
  }
  delay(20);

  IDPaket = data[0];
  DataPenerimaPaket = data[1];
  DataPengirim = data[2];
  Tujuan = data[3];

  delay(10);
  parsingDataPenerima();
  delay(50);
  parsingDataPengirim();
  delay(50);

  IDPaket.getBytes(data_id_brg, 17);
  Tujuan.getBytes(data_tujuan, pjg17);  
}

void parsingDataPengirim()
{
  int j = 0;
  data[j] = "";

  for(int i = 0; i < DataPengirim.length(); i++)
  {
    if ((DataPengirim[i] == '|'))
    {
      j++;
      data[j] = "";
    }
    else
    {
      data[j] = data[j] + DataPengirim[i];
      delay(1);
    }
  }
  delay(5);

//---------------------------------------------------------------------------- NAMA PENGIRIM
  if(data[0].length() > pjg16)
  {
    data[0].substring(0,pjg16).getBytes(data_nama_pgm1, pjg17);
    data[0].substring(15).getBytes(data_nama_pgm2, pjg17);
  }
  else   
  {    
    data[0].getBytes(data_nama_pgm1, pjg17);
    data_nama_pgm2[pjg16] = 0;
  }
  delay(10);

//---------------------------------------------------------------------------- ALAMAT PENGIRIM
  if(data[1].length() > pjg16)
  {
    data[1].substring(0,pjg16).getBytes(data_alam_pgm1, pjg17);
    data[1].substring(15).getBytes(data_alam_pgm2, pjg17);
  }
  else
  {
    data[1].getBytes(data_alam_pgm1, pjg17);
    data_nama_pgm2[pjg16] = 0;
  }
  delay(10);

//---------------------------------------------------------------------------- HAPE PENGIRIM
  data[2].getBytes(data_hp_pgm, pjg17);

  delay(10);
}

void parsingDataPenerima()
{
  int j = 0;
  int m;
  String save_alamat[6] = "";
  data[j] = "";
  
  for(int i = 0; i < DataPenerimaPaket.length(); i++)
  {
    if ((DataPenerimaPaket[i] == '|'))
    {
      j++;
      data[j] = "";
    }
    else
    {
      data[j] = data[j] + DataPenerimaPaket[i];
    }
  }
  delay(5);
  
//---------------------------------------------------------------------------- NAMA PENERIMA
  if(data[0].length() > pjg16)
  {
    data[0].substring(0,pjg16).getBytes(data_nama_pnm1, pjg17);
    data[0].substring(pjg16).getBytes(data_nama_pnm2, pjg17);
  }
  else
  {
    data[0].getBytes(data_nama_pnm1, pjg17);
    data_nama_pnm2[pjg16] = 0;
  }
  delay(10);

//---------------------------------------------------------------------------- ALAMAT PENERIMA
  if (data[1].length()>16)
  {
    int l = data[1].length()%16;
    int z = data[1].length()/16;
    int n = 0;
    if (l > 0)
    {
      z = z + 1;
    }
    for (m = 1; m <= z; m++)
    {
      save_alamat[m] = data[1].substring(n, n+pjg16);
      n = n + pjg16;
    }
  }
  else
  {
    data[1].getBytes(data_alam_pnm1, pjg17);
    data_alam_pnm2[pjg16] = 0;
    data_alam_pnm3[pjg16] = 0;
    data_alam_pnm4[pjg16] = 0;
    data_alam_pnm5[pjg16] = 0;
    data_alam_pnm6[pjg16] = 0;
  }

  delay(10);
  save_alamat[1].getBytes(data_alam_pnm1, pjg17);
  save_alamat[2].getBytes(data_alam_pnm2, pjg17);
  save_alamat[3].getBytes(data_alam_pnm3, pjg17);
  save_alamat[4].getBytes(data_alam_pnm4, pjg17);
  save_alamat[5].getBytes(data_alam_pnm5, pjg17);
  save_alamat[6].getBytes(data_alam_pnm6, pjg17);
  delay(10);

//---------------------------------------------------------------------------- KECAMATAN PENERIMA
  if(data[2].length() > pjg16)
  {
    data[2].substring(0,pjg16).getBytes(data_keca_pnm1, pjg17);
    data[2].substring(pjg16).getBytes(data_keca_pnm2, pjg17);
  }
  else
  {
    data[2].getBytes(data_keca_pnm1, pjg17);
    data_keca_pnm2[pjg16] = 0;
  }
  delay(10);

//---------------------------------------------------------------------------- KOTA PENERIMA
  if(data[3].length() > pjg16)
  {
    data[3].substring(0,pjg16).getBytes(data_kota_pnm1, pjg17);
    data[3].substring(pjg16).getBytes(data_kota_pnm2, pjg17);
  }
  else
  {
    data[3].getBytes(data_kota_pnm1, pjg17);
    data_kota_pnm2[pjg16] = 0;
  }
  delay(10);
  
//---------------------------------------------------------------------------- PROVINSI PENERIMA
  if(data[4].length() > pjg16)
  {
    data[4].substring(0,pjg16).getBytes(data_prov_pnm1, pjg17);
    data[4].substring(pjg16).getBytes(data_prov_pnm2, pjg17);
  }
  else
  {
    data[4].getBytes(data_prov_pnm1, pjg17);
    data_prov_pnm2[pjg16] = 0;
  }
  delay(10);
  
//---------------------------------------------------------------------------- KODEPOS PENERIMA
  data[5].getBytes(data_kode_pnm, pjg17);
  delay(10);

//---------------------------------------------------------------------------- HAPE PENERIMA
  data[6].getBytes(data_hp_pnm, pjg17);
  delay(10);
}

void savetoRFID()
{
  writeBlock(id_brg, data_id_brg);
  
  writeBlock(nama_pgm1, data_nama_pgm1);
  writeBlock(nama_pgm2, data_nama_pgm2);
  writeBlock(alam_pgm1, data_alam_pgm1);
  writeBlock(alam_pgm2, data_alam_pgm2);
  writeBlock(hp_pgm, data_hp_pgm);

  writeBlock(nama_pnm1, data_nama_pnm1);
  writeBlock(nama_pnm2, data_nama_pnm2);
  writeBlock(alam_pnm1, data_alam_pnm1);
  writeBlock(alam_pnm2, data_alam_pnm2);
  writeBlock(alam_pnm3, data_alam_pnm3);
  writeBlock(alam_pnm4, data_alam_pnm4);
  writeBlock(alam_pnm5, data_alam_pnm5);
  writeBlock(alam_pnm6, data_alam_pnm6);
  writeBlock(keca_pnm1, data_keca_pnm1);
  writeBlock(keca_pnm2, data_keca_pnm2);
  writeBlock(kota_pnm1, data_kota_pnm1);
  writeBlock(kota_pnm2, data_kota_pnm2);
  writeBlock(prov_pnm1, data_prov_pnm1);
  writeBlock(prov_pnm2, data_prov_pnm2);
  writeBlock(kode_pnm, data_kode_pnm);
  writeBlock(hp_pnm, data_hp_pnm);
  writeBlock(tujuan, data_tujuan);
  Serial.print("OK#");
}

void ambilRFID()
{
  Serial.print("Datae|"); 
  readBlock(id_brg, baca_id_brg);delay(50);

  Serial.print("|"); readBlock(nama_pgm1, baca_nama_pgm1); readBlock(nama_pgm2, baca_nama_pgm2);delay(50);
  Serial.print("|"); readBlock(alam_pgm1, baca_alam_pgm1); readBlock(alam_pgm2, baca_alam_pgm2);delay(50);
  Serial.print("|"); readBlock(hp_pgm, baca_hp_pgm);delay(50);

  Serial.print("|"); readBlock(nama_pnm1, baca_nama_pnm1); readBlock(nama_pnm2, baca_nama_pnm2);delay(50);
  Serial.print("|"); readBlock(alam_pnm1, baca_alam_pnm1); readBlock(alam_pnm2, baca_alam_pnm2); readBlock(alam_pnm3, baca_alam_pnm3);
  readBlock(alam_pnm4, baca_alam_pnm4); readBlock(alam_pnm5, baca_alam_pnm5); readBlock(alam_pnm6, baca_alam_pnm6);delay(50);
  Serial.print("|"); readBlock(keca_pnm1, baca_keca_pnm1); readBlock(keca_pnm2, baca_keca_pnm2);delay(50);
  Serial.print("|"); readBlock(kota_pnm1, baca_kota_pnm1); readBlock(kota_pnm2, baca_kota_pnm2);delay(50);
  Serial.print("|"); readBlock(prov_pnm1, baca_prov_pnm1); readBlock(prov_pnm2, baca_prov_pnm2);delay(50);
  Serial.print("|"); readBlock(kode_pnm, baca_kode_pnm);delay(50);
  Serial.print("|"); readBlock(hp_pnm, baca_hp_pnm);delay(50);
  Serial.print("|"); readBlock(tujuan, baca_tujuan);delay(50);
}

void cleardata()
{
  byte data_id_brg[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_nama_pgm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_nama_pgm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pgm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pgm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_hp_pgm[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  
  byte data_nama_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_nama_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pnm3[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pnm4[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pnm5[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_alam_pnm6[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_keca_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_keca_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_kota_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_kota_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_prov_pnm1[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_prov_pnm2[pjg16] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_kode_pnm[pjg16]  = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
  byte data_hp_pnm[pjg16]    = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
}
  
void cobatulis(byte *datanya, int lengthdata)
{
  for (byte i = 0; i < lengthdata; i++)
  {
    Serial.print(datanya[i] < 0x10 ? " 0" : " ");
    Serial.print(datanya[i], HEX);
  }
}

int writeBlock(int blockNumber, byte arrayAddress[]) 
{
  int largestModulo4Number=blockNumber/4*4;
  int trailerBlock=largestModulo4Number+3;
  if (blockNumber > 2 && (blockNumber+1)%4 == 0){Serial.print(blockNumber);Serial.println(" is a trailer block:");return 2;}

  byte status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, trailerBlock, &key, &(mfrc522.uid));
  if (status != MFRC522::STATUS_OK)
  {
         Serial.println("Authenticate failed: ");
//         Serial.println(mfrc522.GetStatusCodeName(status));
         return 3;
  }
        
  status = mfrc522.MIFARE_Write(blockNumber, arrayAddress, 16);
  //status = mfrc522.MIFARE_Write(9, value1Block, 16);
  if (status != MFRC522::STATUS_OK)
  {
           Serial.print("MIFARE_Write() failed: ");
//           Serial.println(mfrc522.GetStatusCodeName(status));
           return 4;
  }
}

int readBlock(int blockNumber, byte arrayAddress[]) 
{
  int largestModulo4Number=blockNumber/4*4;
  int trailerBlock=largestModulo4Number+3;

  byte status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, trailerBlock, &key, &(mfrc522.uid));
  if (status != MFRC522::STATUS_OK) {
         Serial.print("Error Reading! ");
//         Serial.println(mfrc522.GetStatusCodeName(status));
         return 3;//return "3" as error message
  }
        
  byte buffersize = 18;
  status = mfrc522.MIFARE_Read(blockNumber, arrayAddress, &buffersize);
  if (status != MFRC522::STATUS_OK)
  {
          Serial.print("MIFARE_read() failed: ");
//          Serial.println(mfrc522.GetStatusCodeName(status));
          return 4;//return "4" as error message
  }
  for (int j = 0; j < 16; j++)
  {
    if (arrayAddress[j] == NULL) j++;
    else Serial.write(arrayAddress[j]);
  }
}
