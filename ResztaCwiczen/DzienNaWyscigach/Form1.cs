using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzienNaWyscigach
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }
        private void SetupRaceTrack()
        {
            minimumBet.Text = "Minimualna stawka to " +(int)betAmount.Minimum;

            int startingPosition = dog1.Right - race.Left;
            int raceTrackLength = race.Size.Width;

            dogs[0] = new Greyhound()
            {
                myPicture = dog1,
                racetrackLength = raceTrackLength,
                startingPosition = startingPosition
            };
            dogs[1] = new Greyhound()
            {
                myPicture = dog2,
                racetrackLength = raceTrackLength,
                startingPosition = startingPosition
            };
            dogs[2] = new Greyhound()
            {
                myPicture = dog3,
                racetrackLength = raceTrackLength,
                startingPosition = startingPosition
            };
            dogs[3] = new Greyhound()
            {
                myPicture = dog4,
                racetrackLength = raceTrackLength,
                startingPosition = startingPosition
            };

            guys[0] = new Guy("Janek", null, 50, janekBtn, janekBet);
            guys[1] = new Guy("Bartek", null, 75, bartekBtn, bartekBet);
            guys[2] = new Guy("Arek", null, 45, arekBtn, arekBet);

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void janekBtn_CheckedChanged(object sender, EventArgs e)
        {
            bettorName.Text = "Janek";
        }

        private void bartekBtn_CheckedChanged(object sender, EventArgs e)
        {
            bettorName.Text = "Bartek";

        }

        private void arekBtn_CheckedChanged(object sender, EventArgs e)
        {
            bettorName.Text = "Arek";
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (janekBtn.Checked)
            {
                GuyNumber = 0;
            }
            if (bartekBtn.Checked)
            {
                GuyNumber = 1;
            }
            if (arekBtn.Checked)
            {
                GuyNumber = 2;
            }

            guys[GuyNumber].PlaceBet((int)betAmount.Value, (int)dogNr.Value);
            guys[GuyNumber].UpdateLabels();
        }

        private void raceBtn_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDog;
            race.Enabled = false;

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < dogs.Length; i++)
                {
                    if (dogs[i].Run())
                    {
                        winningDog = i + 1;
                        NoWinner = false;
                        MessageBox.Show("Wygrywa pies nr " + winningDog);
                        foreach (Guy guy in guys)
                        {
                            if (guy.myBet != null)
                            {
                                guy.Collect(winningDog);
                                guy.myBet = null;
                                guy.UpdateLabels();
                            }
                        }
                        foreach (Greyhound dog in dogs)
                        {
                            dog.takeStartingPosition();
                        }
                        break;
                    }
                }
            }

            race.Enabled = true;
        }
    }
}
