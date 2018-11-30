using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConnectionDialogue : UserControl
    {
        public ConnectionDialogue()
        {
            InitializeComponent();
        }
        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }
        private void updatePercent(string i, string s, bool setinivs = false)
        {
            if (ControlInvokeRequired(label1, () => updatePercent(i, s, setinivs))) return;
            label1.Text = i;
            label2.Text = s;
            this.Visible = !setinivs;
        }
        public void setConnection(string t, string c, bool setinvis = false)
        {
            updatePercent(c, t, setinvis);
        }
        private void ConnectionDialogue_Load(object sender, EventArgs e)
        {
           
        }
    }
}
