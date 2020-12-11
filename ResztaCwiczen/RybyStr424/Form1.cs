using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RybyStr424
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Game game;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Proszę wpisać imię", "Nie można zacząć gry");
                return;
            }
            game = new Game(textName.Text, new List<string> { "Janek", "Cezary" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            listHand.Enabled = true;
            UpdateForm();
        }
        private void UpdateForm()
        {
            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Proszę wybrać kartę");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "Zwycięscą jest " + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                buttonAsk.Enabled = false;
                listHand.Enabled = false;
            }
            else
                UpdateForm();
        }
    }
}
