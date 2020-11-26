using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaprostyprogram
{
    class Talker
    {
        public static int blahblah(string cos,int liczbarazy)
        {
            string finalString = "";
            for(int i = 1; i <= liczbarazy; i++)
            {
                finalString = finalString + cos + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
