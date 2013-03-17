#include <LiquidCrystal.h>
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

void setup() {
  lcd.begin(16, 2);
  // 9600Baudで通信します。
  Serial.begin(9600);
}

void loop() {
  // テキストを保持します。
  String text = "Count:";
  text += millis()/1000;
  
  // LCDの書き込み開始位置を指定します。
  lcd.setCursor(0, 0);
  // textをlcdに送ります。
  lcd.print(text);
  
  // textをシリアル送信します。
  Serial.println(text);
  
  // シリアル受信した文字列がある場合は
  // LCDの書き込み開始位置を二行目に指定します。
  if(Serial.available() > -1){
    lcd.setCursor(0, 1);
  }
  // シリアル受信した文字列がある間は繰り返し処理をします。
  while (Serial.available()) {
    // lcdに書き込みます。
    lcd.write(Serial.read());
  }
  
  delay(1000);
}

