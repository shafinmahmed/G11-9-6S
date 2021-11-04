
String concatDistance;



//////////////////////////--Ultrasonic 1 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin1 = 22;
const int echoPin1 = 3;
long duration1;
int distance1;
String stringDistance1;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//////////////////////////--Ultrasonic 2 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin2 = 23;
const int echoPin2 = 4;
long duration2;
int distance2;
String stringDistance2;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////--Ultrasonic 3 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin3 = 24;
const int echoPin3 = 5;
long duration3;
int distance3;
String stringDistance3;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//////////////////////////--Ultrasonic 4 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin4 = 25;
const int echoPin4 = 6;
long duration4;
int distance4;
String stringDistance4;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////--Ultrasonic 5 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin5 = 26;
const int echoPin5 = 7;
long duration5;
int distance5;
String stringDistance5;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//////////////////////////--Ultrasonic 6 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin6 = 27;
const int echoPin6 = 8;
long duration6;
int distance6;
String stringDistance6;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//////////////////////////--Ultrasonic 7 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin7 = 28;
const int echoPin7 = 9;
long duration7;
int distance7;
String stringDistance7;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////--Ultrasonic 8 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin8 = 29;
const int echoPin8 = 10;
long duration8;
int distance8;
String stringDistance8;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//////////////////////////--Ultrasonic 8 pin declaration/////////////////////////////////////////////////////////////////////////////
const int trigPin9 = 30;
const int echoPin9 = 11;
long duration9;
int distance9;
String stringDistance9;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








void setup() {


  Serial.begin(115200); // Starts the serial communication


  //////////////////////////--Ultrasonic 1 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin1, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin1, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



  //////////////////////////--Ultrasonic 2 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin2, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin2, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


  //////////////////////////--Ultrasonic 3 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin3, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin3, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


  //////////////////////////--Ultrasonic 4 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin4, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin4, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


  //////////////////////////--Ultrasonic 5 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin5, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin5, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



  //////////////////////////--Ultrasonic 6 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin6, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin6, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Ultrasonic 7 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin7, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin7, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Ultrasonic 8 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin8, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin8, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Ultrasonic 9 Setup/////////////////////////////////////////////////////////////////////////////////////

  pinMode(trigPin9, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin9, INPUT); // Sets the echoPin as an Input
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




}

void loop() {
  //////////////////////////--Ultrasonic 1 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin1, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin1, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin1, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration1 = pulseIn(echoPin1, HIGH);
  // Calculating the distance
  distance1 = duration1 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("Distance1: "); Serial.print(distance1);
  stringDistance1 = String(distance1);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


  //////////////////////////--Ultrasonic 2 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin2, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin2, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin2, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration2 = pulseIn(echoPin2, HIGH);
  // Calculating the distance
  distance2 = duration2 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance2: "); Serial.print(distance2);
  stringDistance2 = String(distance2);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



  //////////////////////////--Ultrasonic 3 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin3, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin3, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin3, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration3 = pulseIn(echoPin3, HIGH);
  // Calculating the distance
  distance3 = duration3 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance3: "); Serial.print(distance3);
  stringDistance3 = String(distance3);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



  //////////////////////////--Ultrasonic 4 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin4, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin4, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin4, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration4 = pulseIn(echoPin4, HIGH);
  // Calculating the distance
  distance4 = duration4 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  // Serial.print("    Distance4: "); Serial.print(distance4);
  stringDistance4 = String(distance4);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Ultrasonic 5 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin5, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin5, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin5, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration5 = pulseIn(echoPin5, HIGH);
  // Calculating the distance
  distance5 = duration5 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance5: "); Serial.print(distance5);
  stringDistance5 = String(distance5);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Ultrasonic 6 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin6, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin6, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin6, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration6 = pulseIn(echoPin6, HIGH);
  // Calculating the distance
  distance6 = duration6 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance6: "); Serial.print(distance6);
  stringDistance6 = String(distance6);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



  //////////////////////////--Ultrasonic 7 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin7, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin7, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin7, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration7 = pulseIn(echoPin7, HIGH);
  // Calculating the distance
  distance7 = duration7 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance7: "); Serial.print(distance7);
  stringDistance7 = String(distance7);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




  //////////////////////////--Ultrasonic 8 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin8, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin8, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin8, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration8 = pulseIn(echoPin8, HIGH);
  // Calculating the distance
  distance8 = duration8 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance8: "); Serial.println(distance8);
  stringDistance8 = String(distance8);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





  //////////////////////////--Ultrasonic 9 Data collection/////////////////////////////////////////////////////////////////////////////////////
  // Clears the trigPin
  digitalWrite(trigPin9, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin9, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin9, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration9 = pulseIn(echoPin9, HIGH);
  // Calculating the distance
  distance9 = duration9 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  //Serial.print("    Distance9: "); Serial.println(distance8);
  stringDistance9 = String(distance9);
  /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


  concatDistance = stringDistance1 + "A" + stringDistance2 + "A" + stringDistance3 + "A" + stringDistance4 + "A" + stringDistance5 + "A" + stringDistance6  + "A" + stringDistance7 + "A" + stringDistance8 + "A" + stringDistance9 ;
  Serial.println(concatDistance);


  delay(50);
}
