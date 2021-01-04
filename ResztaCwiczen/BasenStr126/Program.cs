using System;

namespace BasenStr126
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string poem = "";
            while (x < 4)
            {
                poem = poem + "a";
                if (x < 1)
                {
                    poem = poem + " ";
                }
                poem = poem + "n";
                if (x > 1)
                {
                    poem = poem + " oyster";
                    x = x + 2;
                }
                if (x == 1)
                {
                    poem = poem + "noys ";
                }
                if (x < 1)
                {
                    poem = poem + "oise ";
                }
                x = x + 1;
            }
            Console.WriteLine(poem);
        }
    }
}
