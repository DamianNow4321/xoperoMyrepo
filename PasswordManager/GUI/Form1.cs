using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PasswordManager;

namespace GUI
{
    public partial class Form1 : Form
    {
        bool firstTime = true;
        List<Entry> objEntry = Entry.readFile();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = objEntry;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Entry.SaveToFile(textBox2.Text,textBox3.Text,textBox1.Text);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text ="Nazwa: "+objEntry[listBox1.SelectedIndex].Name+Environment.NewLine+"Login: "+objEntry[listBox1.SelectedIndex].Login
                + Environment.NewLine + "Hasło: " + objEntry[listBox1.SelectedIndex].Password;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            objEntry=Entry.searchPasswords(textBox4.Text);
            listBox1.DataSource = objEntry;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MPassC = Entry.loadMasterPassword();
            string mpass = Entry.Hash(textBox5.Text);
            if (MPassC == "")
            {
                firstTime = true;
            }
            if (mpass == MPassC || firstTime == true)
            {
                textBox4.Visible = true;
                listBox1.Visible = true;
                richTextBox1.Visible = true;
                button2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
