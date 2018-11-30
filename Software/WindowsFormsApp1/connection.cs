using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHS.ArduinoSharp;
namespace WindowsFormsApp1
{
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }
        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }
        private void updatePercent(string i, string s)
        {
            if (ControlInvokeRequired(label1, () => updatePercent(i, s))) return;
            label1.Text = i;
            label2.Text = s;
        }
        public void setConnection(string t, string c)
        {
            updatePercent(c, t);
        }
        private void connection_Load(object sender, EventArgs e)
        {

            
        }

        private void Sc_HandshakeMade(SharpController s)
        { 
            
        }
    }
}
