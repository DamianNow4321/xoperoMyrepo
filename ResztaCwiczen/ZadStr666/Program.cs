using System;

namespace ZadStr666
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj datę urodzin: ");
            string birthday = Console.ReadLine();
            Console.Write("Podaj wzrost w centymetrach: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.ReadKey();
        }
    }
}
