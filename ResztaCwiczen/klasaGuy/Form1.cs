using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaGuy
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank=100;
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash=50 ,Name="Joe"};
            bob = new Guy() { Cash=100 ,Name = "Bob" };
            bob.Name = "Bob";
            bob.Cash = 100;
        }
        public void UpdateForm()
        {
            joelabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            boblabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            banklabel.Text = "Bank ma " + bank + " zł";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
