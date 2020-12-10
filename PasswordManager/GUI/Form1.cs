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
    }
}
