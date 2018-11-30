using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finish1_Load(object sender, EventArgs e)
        {
           
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {

            Coffee c = chooser1.getCoffee();
            finish1.PerformBrew(c);
            chooser1.Visible = false;
            bunifuTransition1.ShowSync(finish1);


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            s.Close();
            s.Connect();
            //s.robotArm.Write("home");
            s.Close();
            bunifuTransition1.Show(chooser1);
           
        }

        private void finish1_Load_1(object sender, EventArgs e)
        {

        }

        private void chooser1_Load(object sender, EventArgs e)
        {
           
        }
        Serial s = new Serial();
        ConnectionDialogue c;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.finish1.f1 = this;
            new bg().Show();
            c = connectionDialogue1;
            s = new Serial();
            
            if (s.Connect())
            {
                s.connectedPort.DataReceived += ConnectedPort_DataReceived;
                s.connectedPort.Write("handshake");
                s.robotArm.DataReceived += RobotArm_DataReceived;

                Visible = false;
            } else
            {
                c.setConnection(":(", "Connection Failed");
            }
           
     
            chooser1.finishButton.Click += FinishButton_Click;
        }

        private void RobotArm_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = s.robotArm.ReadExisting();
            if (data == "returned")
            {
                finish1.Visible = false;
                chooser1.Visible = false;
            }
        }

        private void ConnectedPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string exist = s.connectedPort.ReadExisting();
            if (exist == "h/s")
            {


                c.setConnection("Connected", "Setting up (1/6)");
                s.TogglePump(1, true);
                s.TogglePump(1, false);
                c.setConnection("Connected", "Setting up (2/6)");
                s.TogglePump(2, true);
                s.TogglePump(2, false);
                c.setConnection("Connected", "Setting up (3/6)");
                s.TogglePump(3, true);
                s.TogglePump(3, false);

                c.setConnection("Connected", "Setting up (4/6)");
                s.TogglePump(4, true);
                s.TogglePump(4, false);
                c.setConnection("Connected", "Setting up (5/6)");
                s.TogglePump(5, true);
                s.TogglePump(5, false);
                c.setConnection("Connected", "Setting up (6/6)");
                s.TogglePump(6, true);
                s.TogglePump(6, false);

                s.robotArm.Write("home");
                s.Close();

                c.setConnection("C", "C", true);
            
            }
        }

        private void connectionDialogue1_Load(object sender, EventArgs e)
        {

        }
    }
}
