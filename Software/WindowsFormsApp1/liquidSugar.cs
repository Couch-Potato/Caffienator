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
    public partial class liquidSugar : UserControl
    {
        public liquidSugar()
        {
            InitializeComponent();
        }
        public int getSugar()
        {
            if (s_o.selected)
            {
                return 1;
            }
            
            else
            {
                return 0;
            }
        }
        private void liquidSugar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
