const int pinAPWM = 3;
const int pinADir = 12;
const int pinABrake = 9;

const int pinBPWM = 11;
const int pinBDir = 13;
const int pinBBrake = 8;

const int pinGreen = 2;
const int pinRed = 4;

const int pos[] =
  {0, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000};

long time = 0;
long lastTime = 0;
int ledState = LOW;
byte sandwich[10];

void motor1(int p) {
  digitalWrite(pinADir, HIGH);
  digitalWrite(pinABrake, LOW);
  analogWrite(pinAPWM, 50);
  delay(pos[p]);
  digitalWrite(pinABrake, HIGH);
  delay(1000);
  digitalWrite(pinADir, LOW);
  digitalWrite(pinABrake, LOW);
  analogWrite(pinAPWM, 50);
  delay(pos[p]);
  digitalWrite(pinABrake, HIGH);
  
}

void run() {
  for (int i = 0; i < 10; i++) {
    motor1(sandwich[i]);
  }
}

void flashLed(int l) {
  if (time - lastTime > 500) {
      lastTime = time;
      
      if (ledState == LOW)
        ledState = HIGH;
      else
        ledState = LOW;  
        
      if (l = 0)
        digitalWrite(pinGreen, ledState);
      else
        digitalWrite(pinRed, ledState);
    }
}

void setup() {
  pinMode(pinADir, OUTPUT);
  pinMode(pinABrake, OUTPUT);
  pinMode(pinBDir, OUTPUT);
  pinMode(pinBBrake, OUTPUT);
  
  Serial.begin(9600);
}

void loop() {
  time = millis();
  if (Serial.available() > 0) {
    digitalWrite(pinGreen, HIGH);
    if (Serial.read() == 1) {
      digitalWrite(pinRed, HIGH);
      for (int i = 0; i < 10; i++) {
        sandwich[i] = Serial.read();
      }
      run();
      digitalWrite(pinRed, LOW);
    }
  } else {
    flashLed(0);
  }
  
}