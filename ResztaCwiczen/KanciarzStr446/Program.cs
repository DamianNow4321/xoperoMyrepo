using System;
using System.IO;

namespace KanciarzStr446
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\tajny_plan.txt");
            sw.WriteLine("W jaki sposób pokoać kapitana wspaniałego");
            sw.WriteLine("Kolejny genialny ,tajny plan Kanciarza");
            sw.Write("Stworzę armię klonów, ");
            sw.WriteLine("uwolnię je i wystawię przeciwko mieszkańcom Obiektowa");
            string location = "centrum handlowe";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Koln numer {0} atakuje {1}", number, location);
                if (location == "centrum handlowe") { location = "centrum miasta"; }
                else { location = "centrum handlowe"; }
            }
            sw.Close();
        }
    }
}
