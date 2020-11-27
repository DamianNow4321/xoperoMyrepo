using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public string Name;
        public int EarSize;
        public int WhoAmI()
        {
         MessageBox.Show("Moje uszy mają "+EarSize+" centymetrów szerokości",Name+" mówi...");
         return 0;
        }
    }
}
