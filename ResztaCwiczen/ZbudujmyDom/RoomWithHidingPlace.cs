﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbudujmyDom
{
    class RoomWithHidingPlace:Room,IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName)
            : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }
        public override string Description
        {
            get
            {
                return base.Description + " Ktoś może się schować w " + HidingPlaceName + ".";
            }
        }
    }
}