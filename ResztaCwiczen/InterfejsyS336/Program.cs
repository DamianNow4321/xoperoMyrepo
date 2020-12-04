using System;

namespace InterfejsyS336
{
    class Program
    {
        class Tallguy:IClown
        {
            public string Name;
            public int Height;
            public void TalkAboutYourself()
            {
                Console.WriteLine("Nazywam się " + Name + " i mam "+ Height + " centymetrów wzrostu");
            }
            public string FunnyThingIHave
            {
                get { return "duże buty"; }
            }
            public void Honk()
            {
                Console.WriteLine("Tut tuut!");
            }
        }
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duże buty", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.WriteLine(someOtherScaryClown.ScaryThingIHave);
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();
        }
    }
}
