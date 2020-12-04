using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbudujmyDom
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public RoomWithDoor(string name, string decoration,string doorDescription,string hidingPlaceName) : base(name,decoration,hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }
       public override string Description
        {
            get { return base.Description + " Widzisz tutaj " + DoorDescription + "."; }
        }
    }
}
