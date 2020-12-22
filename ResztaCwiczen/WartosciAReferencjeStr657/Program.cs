using System;

namespace WartosciAReferencjeStr657
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine spot = new Canine("Burek", "mops");
            Canine bob = spot;
            bob.Name = "Szarik";
            bob.Breed = "beagle";
            spot.Speak();
            Dog jake = new Dog("Tofik", "pudel");
            Dog betty = jake;
            betty.Name = "Becia";
            betty.Breed = "pitbul";
            jake.Speak();
            Console.ReadKey();
        }
    }
}
