﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasenStr762
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Minivan);
            this.Load += new EventHandler(Motorcycle);
        }
        void Towtruck(object sender, EventArgs e)
        {
            Console.Write("zbliża się ");
        }
        void Motorcycle(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Bicycle);
        }
        void Bicycle(object sender, EventArgs e)
        {
            Console.WriteLine("aby cię złapać!");
        }
        void Minivan(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Dumptruck);
            button1.Click += new EventHandler(Towtruck);
        }
        void Dumptruck(object sender, EventArgs e)
        {
            Console.Write("Palczasty ");
        }
    }
}
