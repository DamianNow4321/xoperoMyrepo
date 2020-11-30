using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
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
            MyRandom = new Random();
            int dst = MyRandom.Next(1, 5);
            Point x = myPicture.Location;
            x.X += dst;
            myPicture.Location = x;
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
            Point x = myPicture.Location;
            x.X = Location;
            myPicture.Location = x;
        }

    }
}
