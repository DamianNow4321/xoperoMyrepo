using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ZdarzeniaTrasowaneStr753
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> outputItems = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            output.ItemsSource = outputItems;
        }
        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Eclipse");
            if (ellipseSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Rectangle");
            if (rectangleSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Grid");
            if (gridSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Border");
            if (borderSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę StackPanel");
        }

        private void UpdateHitTestButton(object sender, RoutedEventArgs e)
        {
            grayRectangle.IsHitTestVisible = (bool)newHitTestVisibleValue.IsChecked;
        }

    }
}
