﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwiazdkiStr824.Model
{
    class StarChangedEventArgs : EventArgs
    {
        public Star StarThatChanged { get; private set; }
        public bool Removed { get; private set; }

        public StarChangedEventArgs(Star starThatChanged, bool removed)
        {
            StarThatChanged = starThatChanged;
            Removed = removed;
        }
    }
}
