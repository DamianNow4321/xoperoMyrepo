using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienNaWyscigach
{
    class Greyhound
    {
        public int startingPosition;
        public int racetrackLength;
        public PictureBox myPicture=null;
        public int Location=0;
        public Random MyRandom;
        public bool Run() {
            myPicture.Left += MyRandom.Next(1,4);
            myPicture.Update();
            if (myPicture.Left >= racetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void takeStartingPosition()
        {
            myPicture.Left = 0;
        }

    }
}
