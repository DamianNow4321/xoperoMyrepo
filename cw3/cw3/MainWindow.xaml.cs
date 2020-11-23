using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cw3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MyLabel.Text = "Nazwa to "+name+"\nx jest równe "+x+"\nd jest równe "+d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MyLabel.Text = "x musi być równe 10";
            }
            else
            {
                MyLabel.Text = "x nie jest równe 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int sValue = 4;
            string name = "Krzysiek";
            if((sValue==3) && (name.Equals("Jan")))
            {
                MyLabel.Text = "sValue jest równe 3 i name Jan";
            }
            MyLabel.Text = "Ten Wiersz jest wykonwany bez względu na warunek";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }
            for(int i = 0; i < 5; i++)
            {
                count--;
            }
            MyLabel.Text = "Odpowiedź brzmi " + count;
        }
    }
}
