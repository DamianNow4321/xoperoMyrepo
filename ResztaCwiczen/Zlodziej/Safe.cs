using System;
using System.Collections.Generic;
using System.Text;

namespace Zlodziej
{
    class Safe
    {
        private Jewels content = new Jewels();
        private string safeComb = "12345";
        public Jewels Open(string combination)
        {
            if (combination == safeComb)
            {
                return content;
            }
            else
                return null;
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeComb);
        }
    }
}
