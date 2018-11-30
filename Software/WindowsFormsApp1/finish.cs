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
    public partial class finish : UserControl
    {
        public Form1 f1;
        public finish()
        {
            InitializeComponent();
        }
        public void PerformBrew(Coffee c)
        {

            new Brew().BrewCoffee(c, this);
        }
        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }
        private void updateVis()
        {
            if (ControlInvokeRequired(f1, () => updateVis())) return;
            
            f1.chooser1.Visible = false;
            f1.finish1.Visible = false;
        }
        private void updatePercent(int i, string s)
        {
            if (ControlInvokeRequired(bunifuCircleProgressbar1, () => updatePercent(i,s))) return;
            bunifuCircleProgressbar1.Value =i;
            bunifuCustomLabel4.Text = s;
        }

        public void setStatus(int percent, string txt)
        {

            if (txt == "Done.")
            {
                System.Threading.Thread.Sleep(1000);
                updateVis();
            }
            else
            {
                updatePercent(percent, txt);
            }
            
        }
        
        private void finish_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
