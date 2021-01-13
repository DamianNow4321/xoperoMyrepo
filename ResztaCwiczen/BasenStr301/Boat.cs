using System;
using System.Collections.Generic;
using System.Text;

namespace BasenStr301
{
    public class Boat
    {
        private int length;
        public void setLength(int len)
        {
            length = len;
        }
        public int getLength()
        {
            return length;
        }
        public virtual string move()
        {
            return "dryfuje ";
        }
    }
}
