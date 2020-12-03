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
            Tallguy tallguy = new Tallguy { Height = 100, Name = "Adam" };
            tallguy.Honk();
        }
    }
}
