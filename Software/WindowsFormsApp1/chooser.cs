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
    public partial class chooser : UserControl
    {
        public chooser()
        {
            InitializeComponent();
        }
  
        public Coffee getCoffee()
        {
            Coffee c = new Coffee();
            c.Sugar = liquidSugar1.getSugar();
            c.Milk = milk1.getMilk();
            c.CoffeeFlavor = flavor1.GetFlavor();
            return c;
        }
        private void chooser_Load(object sender, EventArgs e)
        {
            
        }

        private void finishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
