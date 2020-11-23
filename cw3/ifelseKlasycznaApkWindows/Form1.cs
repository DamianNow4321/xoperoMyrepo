using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseKlasycznaApkWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (label1.Text == "Z prawej")
                {
                    label1.Text = "Z lewej";
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    label1.Text = "Z prawej";
                    label1.TextAlign = ContentAlignment.MiddleRight;

                }
            }
            else
            {
                label1.Text = "Zmiana tekstu wyłączona";
            }
        }
    }
}
