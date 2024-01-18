//incluyo la libreria para el LCD
#include <LiquidCrystal.h>

#define led 2
//pines del sensor1
#define TrigSensor_1 11
#define EchoSensor_1 10
//pines del sensor2
#define TrigSensor_2 13
#define EchoSensor_2 12
int DistanciaMaxima = 29;  //distancia que hay entre sensores
int tam, tmp = 0;
//Crear el objeto LCD con los números correspondientes (rs, en, d4, d5, d6, d7)
LiquidCrystal lcd(8, 3, 4, 2, 7, 6);
//LiquidCrystal lcd(2, 3, 4, 5, 6, 7);

void setup() {
  Serial.begin(9600);
  configuraSensor(TrigSensor_1, EchoSensor_1);
  configuraSensor(TrigSensor_2, EchoSensor_2);
  pinMode(led, OUTPUT);
  // Inicializar el LCD con el número de  columnas y filas del LCD
  lcd.begin(16, 2);
  // Escribimos el Mensaje en el LCD.
  lcd.print("Medidor");

  // ESPERAR A QUE SE ESTABILICE LA ENERGIA
  delay(3000);
}

void loop() {
  tmp = MideTam();
  if (tmp != -1) {
    //me esper unos segundos para que se estabilicen los sensores
    delay(3000);
    tmp = MideTam();
    if (tmp != -1 && tmp != tam) {
      tam = tmp;
      Serial.println("Objeto detectado," + String(tam) + " cm,"+ String(tam/2.5) + " inc");
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Objeto detectado");
      lcd.setCursor(0, 1);
      lcd.print("Mide: " + String(tam) + " cm "+ String(tam/2.5) + " inc");
    }
  } else {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Coloque un objet");
    lcd.setCursor(0, 1);
    lcd.print("o para medir");
  }
  delay(500);  // Para limitar el número de mediciones
}
//configura los pines del sensor como salida
void configuraSensor(int triger, int eco) {
  pinMode(triger, OUTPUT);
  pinMode(eco, INPUT);
}
//lee la iformacion del snsor y regresa la distancia en centimetros
long LeeSensor(int triger, int eco) {
  long duracion, distancia;
  digitalWrite(triger, LOW);   // Nos aseguramos de que el trigger está desactivado
  delayMicroseconds(2);        // Para asegurarnos de que el trigger esta LOW
  digitalWrite(triger, HIGH);  // Activamos el pulso de salida
  delayMicroseconds(10);       // Esperamos 10µs. El pulso sigue active este tiempo
  digitalWrite(triger, LOW);   // Cortamos el pulso y a esperar el echo
  duracion = pulseIn(eco, HIGH);
  distancia = duracion / 2 / 29.1;
  return distancia;
}
//lee los sensores y regresa la distancia que hay entre ellos.
//Regresa -1 si no hay nada entre los sensores
int MideTam() {
  long distancia1, distancia2;
  distancia1 = LeeSensor(TrigSensor_1, EchoSensor_1);
  distancia2 = LeeSensor(TrigSensor_2, EchoSensor_2);
  //Serial.println("Sensor 1: "+String(distancia1) + " cm."+"\t"+"Sensor 2: "+String(distancia2) + " cm.") ;
  if (distancia1 < DistanciaMaxima && distancia2 < DistanciaMaxima) {
    //hay algo entre los sensores, por lo que calculo el tamaño
    return (int)(DistanciaMaxima - distancia1 - distancia2);
  }
  return -1;  //no ha nadaentre los sensores
}