using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbudujmyDom
{
    class Outside: Location
    {
        private bool Hot;
        public Outside(string name, bool hot) : base(name)
        {
            Hot = hot;
        }
        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (Hot)
                    newDescription += " Tutaj jest bardzo gorąco";
                return newDescription;
            }
        }
    }
}
