using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienNaWyscigach
{
    public class Guy
    {
        public string Name;
        public Bet myBet;
        public int Cash;
        public RadioButton myRadiobutton;
        public Label myLabel;

        public Guy(string Name, Bet myBet, int Cash, RadioButton myRadiobutton, Label myLabel)
        {
            this.Name = Name;
            this.myBet = myBet;
            this.Cash = Cash;
            this.myRadiobutton = myRadiobutton;
            this.myLabel = myLabel;
        }
        public void UpdateLabels()
        {
            if (myBet == null)
            {
                myLabel.Text = Name+" nie postawił jeszcze nic";
            }
            else
            {
                myLabel.Text = myBet.GetDesc();
            }
        }
        public void clearBet() { myBet.Amount = 0; }
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                myBet = new Bet(Amount, Dog, this);
                return true;
            }
            return false;
        }

        public void Collect(int Winner)
        {
            Cash += myBet.PayOut(Winner);
        }
    }
}
