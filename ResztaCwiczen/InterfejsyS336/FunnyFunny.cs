using System;
using System.Collections.Generic;
using System.Text;

namespace InterfejsyS336
{
    class FunnyFunny:IClown
    {
        protected string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public string FunnyThingIHave
        {
            get {return "Cześć dzieciaki! Mam " + funnyThingIHave; }
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
