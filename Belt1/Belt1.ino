String concatDistance;
double limit = 50.0;
double maxPWM = 150; // For the mosfets being used 4 volts is maximum gate thrshold voltage so don't use maxium pwm. 150 Seems to work really well


//////////////////////////--Node 1 pin declaration/////////////////////////////////////////////////////////////////////////////
/// ULTRASONIC 1
const int PinData1 = 2;
float duration1;
int distance1;
String stringDistance1;

/// MOTOR 1
int motorSpeed1;
int motor1 = 3;


//////////////////////////--Node 2 pin declaration/////////////////////////////////////////////////////////////////////////////
/// ULTRASONIC 2
const int PinData2 = 4;
float duration2;
int distance2;
String stringDistance2;


/// MOTOR 2
int motorSpeed2;
int motor2 = 5;


//////////////////////////--Node 3 pin declaration/////////////////////////////////////////////////////////////////////////////
/// ULTRASONIC 3
const int PinData3 = 7;
float duration3;
int distance3;
String stringDistance3;


/// MOTOR 3
int motorSpeed3;
int motor3 = 6;


//////////////////////////--Node 4 pin declaration/////////////////////////////////////////////////////////////////////////////
/// ULTRASONIC 4
const int PinData4 = 8;
float duration4;
int distance4;
String stringDistance4;


/// MOTOR 4
int motorSpeed4;
int motor4 = 9;


//////////////////////////--Node 5 pin declaration/////////////////////////////////////////////////////////////////////////////
/// ULTRASONIC 5
const int PinData5 = 12;
float duration5;
int distance5;
String stringDistance5;


/// MOTOR 5
int motorSpeed5;
int motor5 = 10;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


void setup() {
  Serial.begin (9600);

   pinMode(motor1, OUTPUT);
   pinMode(motor2, OUTPUT);
   pinMode(motor3, OUTPUT);
   pinMode(motor4, OUTPUT);
   pinMode(motor5, OUTPUT);
}




void loop() {
  
  //////////////////////////--Node 1/////////////////////////////////////////////////////////////////////////////////////
  
  pinMode(PinData1, OUTPUT);
  digitalWrite(PinData1, LOW);
  delayMicroseconds(2);
  digitalWrite(PinData1, HIGH);
  delayMicroseconds(10);
  digitalWrite(PinData1, LOW);
  pinMode(PinData1, INPUT);
  duration1 = pulseIn(PinData1, HIGH);
  distance1 = (duration1 / 2) * 0.0343;
  //stringDistance1 = String(distance1);
  Serial.print(" stringDistance1: "); Serial.print(distance1);



 
  if (distance1 > limit) {
    distance1 = limit;
  }
  motorSpeed1 = map(distance1, 0, limit, maxPWM, 0);
  analogWrite(motor1, motorSpeed1);
  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Node 2/////////////////////////////////////////////////////////////////////////////////////
  
  pinMode(PinData2, OUTPUT);
  digitalWrite(PinData2, LOW);
  delayMicroseconds(2);
  digitalWrite(PinData2, HIGH);
  delayMicroseconds(10);
  digitalWrite(PinData2, LOW);
  pinMode(PinData2, INPUT);
  duration2 = pulseIn(PinData2, HIGH);
  distance2 = (duration2 / 2) * 0.0343;
  //stringDistance2 = String(distance2);
  Serial.print(" stringDistance2: "); Serial.print(distance2);



 
  if (distance2 > limit) {
    distance2 = limit;
  }
  motorSpeed2 = map(distance2, 0, limit, maxPWM, 0);
  analogWrite(motor2, motorSpeed2);
  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Node 3/////////////////////////////////////////////////////////////////////////////////////
  
  pinMode(PinData3, OUTPUT);
  digitalWrite(PinData3, LOW);
  delayMicroseconds(2);
  digitalWrite(PinData3, HIGH);
  delayMicroseconds(10);
  digitalWrite(PinData3, LOW);
  pinMode(PinData3, INPUT);
  duration3 = pulseIn(PinData3, HIGH);
  distance3 = (duration3 / 2) * 0.0343;
  //stringDistance3 = String(distance3);
  Serial.print(" stringDistance3: "); Serial.print(distance3);



 
  if (distance3 > limit) {
    distance3 = limit;
  }
  motorSpeed3 = map(distance3, 0, limit, maxPWM, 0);
  analogWrite(motor3, motorSpeed3);
  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Node 4/////////////////////////////////////////////////////////////////////////////////////
  
  pinMode(PinData4, OUTPUT);
  digitalWrite(PinData4, LOW);
  delayMicroseconds(2);
  digitalWrite(PinData4, HIGH);
  delayMicroseconds(10);
  digitalWrite(PinData4, LOW);
  pinMode(PinData4, INPUT);
  duration4 = pulseIn(PinData4, HIGH);
  distance4 = (duration4 / 2) * 0.0343;
  //stringDistance4 = String(distance4);
  Serial.print(" stringDistance4: "); Serial.print(distance4);



 
  if (distance4 > limit) {
    distance4 = limit;
  }
  motorSpeed4 = map(distance4, 0, limit, maxPWM, 0);
  analogWrite(motor4, motorSpeed4);
  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Node 5/////////////////////////////////////////////////////////////////////////////////////
  
  pinMode(PinData5, OUTPUT);
  digitalWrite(PinData5, LOW);
  delayMicroseconds(2);
  digitalWrite(PinData5, HIGH);
  delayMicroseconds(10);
  digitalWrite(PinData5, LOW);
  pinMode(PinData5, INPUT);
  duration5 = pulseIn(PinData5, HIGH);
  distance5 = (duration5 / 2) * 0.0343;
  //stringDistance5 = String(distance5);
  Serial.print(" stringDistance5: "); Serial.println(distance5);



 
  if (distance5 > limit) {
    distance5 = limit;
  }
  motorSpeed5 = map(distance5, 0, limit, maxPWM, 0);
  analogWrite(motor5, motorSpeed5);
  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

  

 
  
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

}
