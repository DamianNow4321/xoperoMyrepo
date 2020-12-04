﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbudujmyDom
{
    class Room:Location
    {
        private string Decoration;
        public Room(string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }
        public override string Description
        {
            get
            {
                return base.Description + "Widzisz tutaj "+Decoration+".";
            }
        }
    }
}
