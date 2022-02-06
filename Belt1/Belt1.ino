String concatDistance;
double limit = 50.0;


//////////////////////////--Node 1 pin declaration/////////////////////////////////////////////////////////////////////////////
const int PinData1 = 4;
float duration1;
int distance1;
String stringDistance1;

int motorSpeed1;
int motor1 = 5;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////// TEST BLOCK ///////
//int motor1 = 8;
//int motor2 = 9;







void setup() {
  Serial.begin (9600);

   pinMode(motor1, OUTPUT);
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
  Serial.print("stringDistance1: "); Serial.println(distance1);



 
  if (distance1 > limit) {
    distance1 = limit;
  }
  motorSpeed1 = map(distance1, 0, limit, 255, 0);
  analogWrite(motor1, motorSpeed1);
  //delay(10);
  //analogWrite(motor1, 0);
  ////////////////////////////////////////////////////////

 
  
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

}
