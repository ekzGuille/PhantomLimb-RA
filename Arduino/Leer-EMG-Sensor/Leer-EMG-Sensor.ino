/**
   Imprimir los valores que recibe el sensor por el puerto serie
    (Abrir la terminal del arduino)
*/


//Pin en el que se ha conectado el sensor
int inputPin = A5;
int contador = 1;

void setup(){
  //Baud rates:300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, or 115200
  Serial.begin(9600);
}

void loop(){
    contador = contador + 2;
    // Habra que hacer un Serial.write() del analogRead()
    //Serial.println(analogRead(inputPin));
    Serial.println(contador);
    delay(20);
}

//int onboardLED = 13;            // Arduino onboard LED (pin 13) you can control
//int voltageThreshold = 300;     // any reading higher will trigger an action
//
//void setup() {
//  // put your setup code here, to run when Arduino is powered on:
//  Serial.begin(9600);
//  pinMode(onboardLED, OUTPUT);
//}
//
//void loop() {
//  // put your main code here, to run repeatedly:
//  int currentVoltage = analogRead(A0);  // store the incoming voltage 
//  Serial.print(currentVoltage);         // prints voltage to monitor
//  
//  if(currentVoltage > voltageThreshold){
//     // trigger actions
//     Serial.println(" CONTRACTION!"); // prints string + new line
//     digitalWrite(onboardLED, HIGH);  //this sends 5V, turning on LED
//  } else {
//      Serial.println("");             //adds a new line
//     digitalWrite(onboardLED, LOW); 
//     // turn off the light as threshold is not met
//  }
//}
