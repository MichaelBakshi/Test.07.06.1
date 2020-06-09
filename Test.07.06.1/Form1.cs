using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test._07._06._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtBox.Text);

            if (input == 0)
            {
                lbl.Text = "Zero";
            }
            else if (input < 0)
            {
                lbl.Text = "Negative";

            }
            else if (input > 0)
            {
                lbl.Text = "Positive";

            }
            
            else if (txtBox.Text == null)
            {
                lbl.Text = "Nan";
            }
        }
    }
}
