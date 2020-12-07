using System;
using System.IO;

namespace MagnesyStreamWriter_Str447
{
    class Program
    {
        static void Main(string[] args)
        {
            Flobbo f = new Flobbo("niebiesko-zółta");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
        }
    }
}
