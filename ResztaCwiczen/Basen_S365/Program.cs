using System;
using System.Windows.Forms;

namespace Basen_S365
{
    class Program
    {
        class Of76 : Clowns
        {
            public override string Face
            {
                get { return "Of76"; }
            }
            public static void Main(string[] args)
            {
                string result = "";
                INose[] i = new INose[3];
                i[0] = new Acts();
                i[1] = new Clowns();
                i[2] = new Of76();
                for (int x = 0; x < 3; x++)
                {
                    result += (i[x].Ear() + " " + i[x].Face) + "\n";
                }
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
