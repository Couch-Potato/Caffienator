using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Brew
    {
        Serial s = new Serial();
       
        Coffee cx;
        finish fx;
        public void BrewCoffee(Coffee c, finish f)
        {
            cx = c;
            fx = f;

            s.Connect();
            s.robotArm.DataReceived += RobotArm_DataReceived;
            s.robotArm.Write("home");
            Thread.Sleep(1000);
            s.robotArm.Write("go");
            Thread.Sleep(8000);
            Thread thread = new Thread(new ThreadStart(dostuff));
            thread.Start();
        }

        private void RobotArm_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = s.robotArm.ReadExisting();
            if (data == "done")
            {
               
                Thread thread = new Thread(new ThreadStart(dostuff));
                thread.Start();
                
            }
        }

        private void dostuff()
        {
            s.Close();
            s.Connect();

            List<ProceedingObject> proceedings = new List<ProceedingObject>();
            
            
                int newCoffee = (4 - cx.Milk - 1 - cx.Sugar);
            //MessageBox.Show(cx.Milk.ToString());
            proceedings.Add(new ProceedingObject(ProceedingObject.Object.Coffee, 1));
            proceedings.Add(new ProceedingObject(ProceedingObject.Object.Flavor, 1));
           // MessageBox.Show(cx.Milk.ToString());
            //MessageBox.Show(cx.Sugar.ToString());
            proceedings.Add(new ProceedingObject(ProceedingObject.Object.Milk, cx.Milk));
                proceedings.Add(new ProceedingObject(ProceedingObject.Object.Sugar, cx.Sugar));
            
            proceedings = proceedings.OrderBy(x => x.MS).ToList();
            
            for (int i = 0; i < proceedings.Count; i++)
            {
                //MessageBox.Show($"ID: {i.ToString()}");
                if (i > 0)
                {
                   // MessageBox.Show(proceedings[i].MS.ToString());
                   // MessageBox.Show(proceedings[i-1].MS.ToString());
                    proceedings[i].MS = proceedings[i].MS - proceedings[i - 1].MS;
                   // MessageBox.Show(proceedings[i].MS.ToString());
                }
            }
            string compiled = "";
            proceedings = proceedings.OrderBy(x => x.MS).ToList();
            proceedings.Sort((x, y) => y.MS.CompareTo(x.MS));
            foreach (ProceedingObject po in proceedings)
            {
                compiled = $"{compiled}Object Name: {po.ObjectType}, Object MS: {po.MS} \n\r";
            }
            //MessageBox.Show(compiled);
            fx.setStatus(0, "Starting...");
            int ib = 0;
            foreach (ProceedingObject po in proceedings)
            {
                ib++;
                fx.setStatus(ib * 10, $"Starting {po.ObjectType.ToString()}");
                if (po.ObjectType == ProceedingObject.Object.Flavor)
                {
                    
                    if (cx.CoffeeFlavor == Coffee.Flavor.Caramel)
                    {
                        s.TogglePump(PumpSettings.Caramel, true);
                        s.TogglePump(PumpSettings.Caramel, false);
                    }
                    if (cx.CoffeeFlavor == Coffee.Flavor.Mocha)
                    {
                        s.TogglePump(PumpSettings.Mocha, true);
                        s.TogglePump(PumpSettings.Mocha, false);
                    }
                    if (cx.CoffeeFlavor == Coffee.Flavor.Vanilla)
                    {
                        s.TogglePump(PumpSettings.Vanilla, true);
                        s.TogglePump(PumpSettings.Vanilla, false);
                    }
                }
                if (po.ObjectType == ProceedingObject.Object.Coffee)
                {
                    s.TogglePump(PumpSettings.Coffee, true);
                    s.TogglePump(PumpSettings.Coffee, false);
                }
                if (po.ObjectType == ProceedingObject.Object.Milk)
                {
                    s.TogglePump(PumpSettings.Milk, true);
                    s.TogglePump(PumpSettings.Milk, false);
                }
                if (po.ObjectType == ProceedingObject.Object.Sugar)
                {
                    s.TogglePump(PumpSettings.Sugar, true);
                    s.TogglePump(PumpSettings.Sugar, false);
                }
                fx.setStatus(ib * 25, $"Brewing...");
                Thread.Sleep(po.MS);
            }
          
            fx.setStatus(100, "Done.");
            s.robotArm.Write("return");
        }
    }
    public class ProceedingObject
    {
        public enum Object { Milk,Flavor,Sugar,Coffee};
        public Object ObjectType;
        public int MS;
        public ProceedingObject(Object ot, int oz)
        {
           
            ObjectType = ot;
            MS = oz * 0;
          
            //MessageBox.Show($"Object: {ot.ToString()} \n\rOunces: {oz}\n\rMS: {MS}");
        }
    }
    public class PumpSettings
    {
        public static int Coffee = 1;
        public static int Milk = 2;
        public static int Sugar = 3;
        public static int Caramel = 4;
        public static int Vanilla = 5;
        public static int Mocha = 6;
        public static string robotArmConnection = "COM13";
        public static string coffeeMakerConnection = "COM4";
    }
}
