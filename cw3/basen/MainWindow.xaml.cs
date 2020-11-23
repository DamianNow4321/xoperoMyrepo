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

namespace basen
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

        private void cText_Click(object sender, RoutedEventArgs e)
        {
            if (enCheckbox.IsChecked == true)
            {
                if (label.Text == "Z prawej")
                {
                    label.Text = "Z lewej";
                    label.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    label.Text = "Z prawej";
                    label.HorizontalAlignment = HorizontalAlignment.Right;

                }
            }
            else
            {
                label.Text = "Zmiana tekstu wyłączona";
            }
        }
    }
}
