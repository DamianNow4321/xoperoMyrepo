using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienNaWyscigach
{
        public class Bet
        {
            public int Amount;
            public int Dog;
            public Guy Bettor;

            public Bet(int Amount, int Dog, Guy Bettor)
            {
                this.Amount = Amount;
                this.Dog = Dog;
                this.Bettor = Bettor;
            }

            public string GetDesc()
            {
                string desc = "";

                if (Amount > 0)
                {
                    desc = Bettor.Name + " stawia " + Amount + " na psa nr. " + Dog;
                }
                else
                {
                    desc = Bettor.Name + " nie postawił nic";
              }
                return desc;
            }

            public int PayOut(int Winner)
            {
                if (Dog == Winner)
                {
                    return Amount;
                }
                return -Amount;
            }
        }
}
