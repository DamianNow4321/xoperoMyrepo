using System;

namespace BasenStr623
{
    class Program
    {
        static void Main(string[] args)
        {
            Kangaroo joey = new Kangaroo();
            int koala = joey.Wombat(joey.Wombat(joey.Wombat(1)));
            try
            {
                Console.WriteLine((15 / koala) + " jaj na kilogram");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Witaj bracie!");
            }
        }
    }
}
