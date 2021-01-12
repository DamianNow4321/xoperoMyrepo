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
            listBox2.DataSource = objEntry;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            key = Entry.loadMasterPassword("T");
            bool test=Entry.SaveToFileAlt(textBox1.Text,textBox2.Text,textBox3.Text, "b14ca5898a4e4133bbce2ea2315a1916");
            List<Entry> objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
            listBox1.DataSource = objEntry;
            if (test == false)
            {
                MessageBox.Show("Plik o takej nazwie już istnieje. Zmień nazwę");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Entry.pth != null)
            {
                objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
                richTextBox1.Text = "Nazwa: " + objEntry[listBox1.SelectedIndex].Name + Environment.NewLine + "Login: " + objEntry[listBox1.SelectedIndex].Login
                + Environment.NewLine + "Hasło: " + objEntry[listBox1.SelectedIndex].Password;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Entry.searchPasswords(textBox4.Text,objEntry);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Entry.pth != null)
            {
                string MPassC = Entry.loadMasterPassword(textBox5.Text);
                key = Entry.loadMasterPassword(textBox5.Text);
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
                    textBox7.Visible = true;
                    textBox6.Visible = true;
                    button5.Visible = true;
                    button1.Visible = true;
                    changeBtn.Visible = true;
                    delBtn.Visible = true;
                    nazwaChange.Visible = true;
                    loginChange.Visible = true;
                    passChange.Visible = true;
                    listBox2.Visible = true;
                    listBox1.Visible = true;
                    button6.Visible = true;
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
                objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
                listBox1.DataSource = objEntry;
                listBox2.DataSource = objEntry;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Entry.changeSalt(textBox6.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Entry.changeMasterPassword(textBox7.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Entry.pth != null)
            {
                objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
                nazwaChange.Text = objEntry[listBox2.SelectedIndex].Name;
                loginChange.Text = objEntry[listBox2.SelectedIndex].Login;
                passChange.Text = objEntry[listBox2.SelectedIndex].Password;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Entry.removeEntry(objEntry[listBox2.SelectedIndex].Name);
            objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
            listBox1.DataSource = objEntry;
            listBox2.DataSource = objEntry;
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            Entry.changeEntry(nazwaChange.Text, loginChange.Text, passChange.Text);
            objEntry = Entry.readFileAlt("b14ca5898a4e4133bbce2ea2315a1916");
            listBox1.DataSource = objEntry;
            listBox2.DataSource = objEntry;
        }
    }
}
