using System;
using System.Collections.Generic;
using System.Text;

namespace Zlodziej
{
    class Owner
    {
        private Jewels returnedContent;
        public void ReceiveContent(Jewels safeContents)
        {
            returnedContent = safeContents;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów!" + safeContents.Sparkle());
        }

    }
}
