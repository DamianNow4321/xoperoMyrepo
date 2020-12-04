using System;
using System.Collections.Generic;
using System.Text;

namespace InterfejsyS336
{
    interface IScaryClown:IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
