using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void ToggleBouncing(int index, Label labelToBounce)
        {
            if(bouncers[index] == null) {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labelToBounce;
            }
            else {
                bouncers[index] = null;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (bouncers[i] != null)
                {
                    bouncers[i].Move();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleBouncing(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleBouncing(2, label3);
        }
    }
}
