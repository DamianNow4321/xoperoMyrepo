using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlonyStr651
{
    [Serializable]
    class Clone : IDisposable
    {
        public int Id { get; private set; }
        public Clone(int Id)
        {
            this.Id = Id;
        }
        public void Dispose()
        {
            string filename = @"C:\Data\Clone.dat";
            string dirname = @"C:\Data\";
            if (File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }
            MessageBox.Show("Muszę...zaserializować...obiekt!","Klon " + Id + " mówi...");
        }
        ~Clone()
        {
            MessageBox.Show("Aaaaaa! Dopadłeś mnie!", "Klon " + Id + " mówi...");
        }
    }
}
