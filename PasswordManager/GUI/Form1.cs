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
        List<Entry> objEntry;
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = objEntry;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Entry.SaveToFile(textBox1.Text,textBox2.Text,textBox3.Text);
            List<Entry> objEntry = Entry.readFile();
            listBox1.DataSource = objEntry;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Entry.pth != null)
            {
                objEntry = Entry.readFile();
                richTextBox1.Text = "Nazwa: " + objEntry[listBox1.SelectedIndex].Name + Environment.NewLine + "Login: " + objEntry[listBox1.SelectedIndex].Login
                    + Environment.NewLine + "Hasło: " + objEntry[listBox1.SelectedIndex].Password;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            objEntry=Entry.searchPasswords(textBox4.Text);
            listBox1.DataSource = objEntry;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Entry.pth != null)
            {
                string MPassC = Entry.loadMasterPassword();
                string mpass = Entry.Hash(textBox5.Text).ToString();
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
            else
                MessageBox.Show("Proszę wybrać najpierw folder z hasłami","Ścieżka");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Entry.pth;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Entry.changePath(folderBrowserDialog1.SelectedPath);
                objEntry = Entry.readFile();
                listBox1.DataSource = objEntry;
            }
        }
    }
}
