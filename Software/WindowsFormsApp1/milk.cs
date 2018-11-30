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
    public partial class milk : UserControl
    {
        public milk()
        {
            InitializeComponent();
        }
        public int getMilk()
        {
            if (m_t.selected)
            {
                return 1;
            }
           
            else
            {
                return 0;
            }



        }
        private void milk_Load(object sender, EventArgs e)
        {

        }
    }
}
