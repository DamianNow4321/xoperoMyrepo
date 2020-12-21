using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlonyRozdział13
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
            MessageBox.Show("Zostałem usunięty","Klon " + Id + " mówi...");
        }
        ~Clone()
        {
            MessageBox.Show("Aaaaaa! Dopadłeś mnie!","Klon " + Id + " mówi...");
        }
    }
}
