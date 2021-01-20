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

namespace ProstyEdytorTekstuWPFStr572
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool textChanged = false;
        bool loading = false;
        IStorageFile saveFile = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFile()
        }

        private async void openBtn_Click(object sender, RoutedEventArgs e)
        {
            if (textChanged)
            {
                MessageBox overwriteDialog = new MessageDialog(
                   "Masz niezapisane zmiany");
                overwriteDialog.Commands.Add(new UICommand("Tak"));
                overwriteDialog.Commands.Add(new UICommand("Nie"));
                overwriteDialog.DefaultCommandIndex = 1;
                UICommand result = await overwriteDialog.ShowAsync() as UICommand;
                if (result != null && result.Label == "Nie")
                    return;
            }
            OpenFile();
        }
        private async void OpenFile()
        {
            FileOpenPicker picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.List,
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };
            picker.FileTypeFilter.Add(".txt");
            picker.FileTypeFilter.Add(".xml");
            picker.FileTypeFilter.Add(".xaml");
            IStorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                string fileContents = await FileIO.ReadTextAsync(file);
                loading = true;
                text.Text = fileContents;
                textChanged = false;
                filename.Text = file.Name;
                saveFile = file;
            }
        }
        private async void SaveFile()
        {
            if (saveFile == null)
            {
                FileSavePicker picker = new FileSavePicker
                {
                    DefaultFileExtension = ".txt",
                    SuggestedStartLocation = PickerLocationId.DocumentsLibrary
                };
                picker.FileTypeChoices.Add("plik tekstowy", new List<string>() { ".txt" });
                picker.FileTypeChoices.Add("plik XML", new List<string>() { ".xml", ".xaml" });
                saveFile = await picker.PickSaveFileAsync();
                if (saveFile == null) return;
            }
            await FileIO.WriteTextAsync(saveFile, text.Text);
            await new MessageDialog("Napisał " + saveFile.Name).ShowAsync();
            textChanged = false;
            filename.Text = saveFile.Name;
        }
    }
}
