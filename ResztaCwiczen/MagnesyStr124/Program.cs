using System;

namespace MagnesyStr124
{
    class Program
    {
        static void Main(string[] args)
        {
            string result ="";
            int x = 3;
            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }
                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }
                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
