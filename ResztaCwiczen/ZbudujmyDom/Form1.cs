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

        int Moves;
        Opponent opponent;
        Location currentLocation;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;
        OutsideWithHidingPlace garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace driveway;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan","dębowe drzwi z mosiężną klamką","W szafie ściennej");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "krzyształowy żyrandol","W wysokiej szafie");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "rozsuwane drzwi","w szafce");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false,"w szopie");
            stairs = new Room("Schody", "drewniana poręcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem","w szafie ściennej" );
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko","pod łóżkiem ");
            secondBedroom = new RoomWithHidingPlace("Druga sypialnia", "małe łóżko ","pod łóżkiem");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta ","pod prysznicem ");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w garażu");
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }
        private void RedrawForm()
        {
            ex.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                ex.Items.Add(currentLocation.Exits[i].Name);
            }
            ex.SelectedIndex = 0;
            Description.Text = currentLocation.Description + "\r\n(ruch nr " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Sprawdź " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                button2.Visible = true;
            else
                button2.Visible = false;
        }
        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalazłeś mie w " + Moves + " ruchach");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                Description.Text = "Znalazłeś przeciwnika w " + Moves + " ruchach. Ukrywał się w " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide.Visible = true;
            button1.Visible = false;
            check.Visible = false;
            button2.Visible = false;
            ex.Visible = false;
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
        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                Description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            Description.Text = "Gotowy czy nie nadchodzę!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            button1.Visible = true;
            ex.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
