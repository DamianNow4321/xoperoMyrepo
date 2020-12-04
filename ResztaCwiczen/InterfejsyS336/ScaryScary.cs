using System;
using System.Collections.Generic;
using System.Text;

namespace InterfejsyS336
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return "Mam " + numberOfScaryThings + " pająków"; }
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Nie możesz mieć mojego "+base.funnyThingIHave);
        }
    }
}
