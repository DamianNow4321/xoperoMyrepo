using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanistaPrzyjec2._0
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                                    checkBox1.Checked, checkBox2.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numericUpDownBirthday.Value,
                  checkBox3.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBox2.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            dinnerParty.FancyDecorations = checkBox1.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    private void DisplayDinnerPartyCost()
    {
            decimal Cost = dinnerParty.Cost;
            koszt.Text = Cost.ToString("c");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = checkBox3.Checked;
            DisplayBirthdayPartyCost();
        }

        private void numericUpDownBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
        private void DisplayBirthdayPartyCost()
        {
            tooLongText.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            bCost.Text = cost.ToString("c");
        }
    }
}
