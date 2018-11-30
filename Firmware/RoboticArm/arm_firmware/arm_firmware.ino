#include <Servo.h>
Servo servos[7];

void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  servos[1].attach(2);
  servos[2].attach(3);
  servos[3].attach(4);
  servos[4].attach(5);
  servos[5].attach(6);
  servos[6].attach(7);
}

void moveServo(int servo, int amt)
{
  servos[servo].write(amt);
  }

void turn(int deg)
{
  
  }
 void retBase()
 {

  }
void loop() {
  // put your main code here, to run repeatedly:
  while (Serial.available() > 0) {
     String s = Serial.readString();
     if (s.equals("home"))
     {
      moveServo(1,0);
      moveServo(2,140);
      moveServo(3,80);
      moveServo(4,20);
      moveServo(5,10);
      }
      if (s.equals("go"))
      {
        moveServo(1,130);
        delay(2000);
        moveServo(2,180);
        moveServo(3,140);
        moveServo(4,45);
        moveServo(5,10);
        delay(3000);
        moveServo(5,90);
        delay(1000);
        moveServo(2,140);
        moveServo(3,80);
        moveServo(4,20);
        delay(3000);
        moveServo(1,180);
        delay(1000);
        moveServo(2,180);
        moveServo(3,140);
        moveServo(4,45);
        Serial.print("done");
        }
        if (s.equals("return"))
        {
           moveServo(2,140);
        moveServo(3,80);
        moveServo(4,20);
        delay(1000);
        moveServo(1,25);
        delay(2000);
        moveServo(2,180);
        moveServo(3,140);
        moveServo(4,45);
        delay(1000);
        moveServo(5,10);
        Serial.print("returned");
          }
  }
  
}
