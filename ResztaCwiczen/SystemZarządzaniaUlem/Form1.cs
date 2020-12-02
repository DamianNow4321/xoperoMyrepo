using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemZarządzaniaUlem
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" }, 175);
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczułek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z żadłami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczułek", "Utrzymanie ula", "Patrol z żadłami" }, 155);
            queen = new Queen(workers, 275);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Nie ma robotnic do wykonania ‘" + workBeeJob.Text + "’", "Królowa pszczół mówi...");
            else
                MessageBox.Show("Zadanie ‘" + workBeeJob.Text + "’ będzie ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi...");
        }

        private void nxtShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
