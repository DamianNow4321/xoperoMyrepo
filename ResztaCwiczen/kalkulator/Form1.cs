using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zwrot = 0.39;
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                double stanlicz = (double)(numericUpDown2.Value - numericUpDown1.Value);
                double iloscPien = stanlicz * zwrot;
                label4.Text = iloscPien.ToString() + " zł";
            }
            else
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy", "Nie mogę obliczyć odległości");
            }
        }
    }
}
