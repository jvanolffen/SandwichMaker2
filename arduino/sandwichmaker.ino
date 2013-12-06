const int pinDirection = 12;
const int pinPWM = 3;
const int pinBrake = 9;
const int pinCurrentSensing = 0;
int pwm = 0;

void setup() {
  pinMode(pinDirection, OUTPUT);
  pinMode(pinBrake, OUTPUT);
}

void loop() {
  digitalWrite(pinDirection, LOW);
  digitalWrite(pinBrake, LOW);
  analogWrite(pinPWM, 255);
  delay(1000);
  
  digitalWrite(pinDirection, HIGH);
  digitalWrite(pinBrake, LOW);
  analogWrite(pinPWM, 255);
  delay(1000);
}