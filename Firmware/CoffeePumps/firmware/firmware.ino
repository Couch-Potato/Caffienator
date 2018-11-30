#include <Servo.h>



void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  pinMode(7, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(2, OUTPUT);
digitalWrite(7, HIGH);
  digitalWrite(6, HIGH);
  digitalWrite(5, HIGH);
  digitalWrite(4, HIGH);
  digitalWrite(3, HIGH);
  digitalWrite(2, HIGH);
}


//Start the steam carnival project
void writeDataPacket(String header, String data[])
{
  String datas = header;
  for (int i = 0; i < sizeof(data); i++)
  {
    datas = datas + "&%&" + data[i];
    }
    Serial.print(datas);
  }


bool readingPacket = false;
String _header = "";
String dta[] = {"","","",""};
int dataa = -1;
void onDataPacket(String header, String data[])
{
  //do this when you want to read the data
Serial.print(header + " Data: " + data[0] + " On " + data[1]);
  if (header.equals("pump") && data[0].equals("on"))
  {
    
    digitalWrite(data[1].toInt(), LOW);
    }
    
      if (header.equals("pump") && data[0].equals("off"))
  {
    digitalWrite(data[1].toInt(), HIGH);
    }
    if (header.equals("servo"))
    {
      
      }
    
    
  }
  




bool contains (String needle, String haystack)
{
   return (haystack.indexOf(needle) >= 0);
  
    
  }



  

  





  bool isConnected = false;
void loop() {
  // put your main code here, to run repeatedly:
  
  while (Serial.available() > 0) {
     String s = Serial.readString();
    if (s.equals("handshake")) {
  

     

       Serial.print("h/s");
 
        isConnected = true;
       // digitalWrite(communcationLight, HIGH);
      }else
      {
        
       
        if (readingPacket == false)
        {

          readingPacket = true;
          _header = s;
          }else
          {
            
            
            if (s == "/e/o/t")
            {
              
            
              readingPacket = false;
              dataa = -1;
              onDataPacket(_header, dta);
              }else
              {
                dataa += 1;
                
                
                dta[dataa] = s;
                }
            }
        }

    
  }
}
