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
    public partial class flavor : UserControl
    {
        public flavor()
        {
            InitializeComponent();
        }

        public Coffee.Flavor GetFlavor()
        {
            if (f_c.selected)
            {
                return Coffee.Flavor.Caramel;
            }
            else if (f_m.selected)
            {
                return Coffee.Flavor.Mocha;
            }
            else if (f_c.selected)
            {
                return Coffee.Flavor.Vanilla;
            }
            else
            {
                return Coffee.Flavor.None;
            }
        }

        private void flavor_Load(object sender, EventArgs e)
        {

        }
    }
}
