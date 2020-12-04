using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarządzaniaUlem
{
    public interface iStingPatrol
    {
        int AlertLevel { get; set; }
        int StingerLength { get; set; }
        bool lookForEnemies();
        int SharpenStinger(int length);
    }
    public interface iNectarCollector
    {
        void FindFlowers();
        void GateherNectar();
        void ReturnToHive();
    }
}
