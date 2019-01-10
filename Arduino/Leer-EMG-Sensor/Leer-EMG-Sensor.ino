/**
   Imprimir los valores que recibe el sensor por el puerto serie
    (Abrir la terminal del arduino)
*/

#include "SPI.h"

int x = 0;

void setup() {
  //Baud rates:300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, or 115200
  Serial.begin(9600);
}

void loop() {
  Serial.println(analogRead(x));
}
