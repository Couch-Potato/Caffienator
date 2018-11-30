using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Serial
    {
        public SerialPort connectedPort;
        public SerialPort robotArm;
        public bool Connect()
        {
            try
            {
                connectedPort = new SerialPort(PumpSettings.coffeeMakerConnection, 9600);
                connectedPort.Open();
                robotArm = new SerialPort(PumpSettings.robotArmConnection, 9600);
                robotArm.Open();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public void Close()
        {
            connectedPort.Close();
            robotArm.Close();
        }
        public void SendArmAction(string action)
        {
            robotArm.Write(action);
        }
        public void TogglePump(int n, bool on)
        {
            if (on)
            {
                connectedPort.Write("pump");
                System.Threading.Thread.Sleep(1200);
                connectedPort.Write("on");
                System.Threading.Thread.Sleep(1200);
                connectedPort.Write((n+ 1).ToString());
                System.Threading.Thread.Sleep(1200);
                connectedPort.Write("/e/o/t");
                System.Threading.Thread.Sleep(1200);
            }
            else
            {
                connectedPort.Write("pump");
                System.Threading.Thread.Sleep(1200);
                connectedPort.Write("off");
                System.Threading.Thread.Sleep(1200);
                connectedPort.Write((n + 1).ToString());
                System.Threading.Thread.Sleep(1200);
                connectedPort.Write("/e/o/t");
                System.Threading.Thread.Sleep(1200);
            }
          
        }
    }
}
