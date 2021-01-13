using System;

namespace BasenStr301
{
    class Program
    {
        static void Main(string[] args)
        {
            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            xyz = b1.move();
            xyz += b3.move();
            xyz += b2.move();
            Console.WriteLine(xyz);
        }
    }
}
