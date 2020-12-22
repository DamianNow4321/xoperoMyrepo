using System;
using System.Collections.Generic;
using System.Text;

namespace BasenStr667
{
    public class Faucet
    {
        public Faucet()
        {
            Table wine = new Table();
            Hinge book = new Hinge();
            wine.Set(book);
            book.Set(wine);
            wine.Lamp(10);
            book.garden.Lamp("z powrotem za");
            book.bulb *= 2;
            wine.Lamp("minut");
            wine.Lamp(book);
        }
    }
}
