#include <LiquidCrystal.h>
LiquidCrystal lcd(8, 9, 4, 5, 6, 7); //atmega 2560 lcd shield ayarı yapılmıştır.
const int kirmiziLed=52; // c# arayüz uygulamasından müdaheleyi temsilen yanacaktır.
const int maviLed=26; //su motorunu temsilen kullanılacaktır.
const int sariLed=30; // su seviyesinin yeterli olmadığı durumda çalışacaktır.
const int yesilLed=36; // se seviyesi ve toprak nemi istenilen seviyede ise çalışacaktır.
const int buzzer=40; // su motoru çalıştığında buzzer ses çıkaracaktır.
const int nemSensorPin= A8; 
const int suSensorPin= A9; //const sabitlenmesi için kullanıldı 
int nemSeviyesi;
int suSeviyesi;
void setup() {
  pinMode(kirmiziLed,OUTPUT);
  pinMode(maviLed,OUTPUT);
  pinMode(sariLed,OUTPUT);
  pinMode(yesilLed,OUTPUT);
  pinMode(buzzer,OUTPUT);
  Serial.begin(9600); 
  Serial2.begin(9600); // hc-05 bluetooth modülün tx ve rx bacakları arduino kartın tx2 ve rx2 bacaklarına baglandı.  
  lcd.begin(16,2); // lcd shiel ayarı yapıldı.
  lcd.setCursor(0,0); //imlecin başlangıç konumu verilmiştir.
}
char mesaj;
// Akıllı Sulama Sistemi uygulamasından gelen deger ile su motorunu çalıştırma fonksiyonu 5 saniyeliğine çalışacaktır.
void suMotorunuCalistir(){
    digitalWrite(kirmiziLed,HIGH);
    digitalWrite(maviLed,HIGH);
    digitalWrite(buzzer,LOW);
    digitalWrite(yesilLed,LOW);
    digitalWrite(sariLed,LOW);
    Serial2.println(nemSeviyesi); //Su motoru çalışırken ölçülen nem değeri mobil cihaza gönderilecektir.
    //su motoru çalıştığı zaman lcd shield içerisinde  su motoru calisiyor yazacaktır.
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Su motoru");
    lcd.setCursor(0,1);
    lcd.print("calisiyor.");
    // Yapılan müdahele ile su motoru 5 saniye çalışacaktır.
    delay(5000);
    } 
void loop() {
   mesaj='0'; // c# arayüzünde su motorunu çalıştır dendiğinde uygulamanın donmaması için yazıldı.
   mesaj=Serial.read(); // akıllı sulama sistemi uygulamasından gelen deger okundu.
   digitalWrite(buzzer,LOW); //buzzer pasif durumda.
   nemSeviyesi=analogRead(nemSensorPin);   // nem degeri ölçülüyor.
   Serial.print(nemSeviyesi); //nem degeri seri port ekranına yazdırılıyor.
   suSeviyesi=analogRead(suSensorPin);  // su seviyesi ölçülüyor.
   Serial.print("*"); // C#'da Split metoduyla iki veriyi ayırmak için kullanılacak.
   Serial.println(suSeviyesi); // su seviyesi seri port ekranına yazdırıldı.
   lcd.setCursor(0,0); //lcd shield imleç konumu belirlendi.
   //nem seviyesi ve su seviyesi beklenilen değerlerde ise yeşil led yanacak.
   if(nemSeviyesi<=750 && suSeviyesi>=300 && mesaj!='1'){
    digitalWrite(yesilLed,HIGH);
    digitalWrite(kirmiziLed,LOW);
    digitalWrite(maviLed,LOW);
    digitalWrite(sariLed,LOW);
    digitalWrite(buzzer,HIGH);
    Serial2.println("Su m. calismiyor..");
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Nem seviyesi:");
    lcd.print(nemSeviyesi);
    lcd.setCursor(0,1);
    lcd.print("Su seviyesi:");
    lcd.print(suSeviyesi);
    //delay(500);
   }
   // su seviyesi beklenilen degerin altında ise uyarı vermek için sari led yanacaktır ve toprak nemi ne olursa olsun mavi led(su motoru) yanmayacaktır.
   if(suSeviyesi<300 && mesaj!='1'){
    digitalWrite(yesilLed,LOW);
    digitalWrite(kirmiziLed,LOW);
    digitalWrite(maviLed,LOW);
    digitalWrite(buzzer,HIGH);
    digitalWrite(sariLed,HIGH);
    Serial2.println("Su m. calismiyor..");
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Su seviyesi");
    lcd.setCursor(0,1);
    lcd.print("yeterli degil.");
   }
   //nem seviyesi beklenilen değerde değil,su seviyeside beklenilen yeterlilikte ise mavi led(su motoru) yanacaktır.
   if(nemSeviyesi>=750 && suSeviyesi>=300 && mesaj!='1'){
    digitalWrite(yesilLed,LOW);
    digitalWrite(kirmiziLed,LOW);
    digitalWrite(maviLed,HIGH);
    digitalWrite(sariLed,LOW);
    digitalWrite(buzzer,LOW);
    Serial2.println(nemSeviyesi); // su motoru calisirken ölçülen nem değeri bluetooth üzerinden telefona gönderilecektir.
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Su motoru");
    lcd.setCursor(0,1);
    lcd.print("devrede...");
   }
   // C# uygulamasından müdahele ile mavi led(su motoru) çalıştırılıyor.
   if(mesaj=='1'){
    suMotorunuCalistir();
    }
   delay(300); // bir saniye sonra sistem başa dönecektir.
}


