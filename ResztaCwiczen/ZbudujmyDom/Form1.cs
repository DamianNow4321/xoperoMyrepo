using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZbudujmyDom
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        Room diningRoom;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;
        Outside garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan","dębowe drzwi z mosiężną klamką");
            diningRoom = new Room("Jadalnia", "krzyształowy żyrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "rozsuwane drzwi");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new Outside("Ogród", false);
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            ex.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                ex.Items.Add(currentLocation.Exits[i].Name);
            ex.SelectedIndex = 0;
            Description.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
                button2.Visible = true;
            else
                button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[ex.SelectedIndex]);
        }
    }
}
