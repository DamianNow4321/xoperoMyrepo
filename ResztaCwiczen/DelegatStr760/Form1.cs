using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatStr760
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();
        private void button1_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
                MessageBox.Show("Dodam " + ingredientMethod((int)amount.Value));
            else
                MessageBox.Show("Nie mam tajnego składnika!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmysSecretIngredientMethod);
        }
    }
}
