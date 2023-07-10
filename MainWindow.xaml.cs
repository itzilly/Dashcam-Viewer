using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace Dashcam_Viewer
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

        private void FileMenu_OpenSdCard_Click(object sender, RoutedEventArgs e)
        {
            // string currentDirectory = "C:\\";
            // var dlg = new CommonOpenFileDialog();
            // dlg.Title = "Select Drive";
            // dlg.IsFolderPicker = true;
            // dlg.InitialDirectory = currentDirectory;

            // dlg.AddToMostRecentlyUsedList = false;
            // dlg.AllowNonFileSystemItems = false;
            // dlg.DefaultDirectory = currentDirectory;
            // dlg.EnsureFileExists = true;
            // dlg.EnsurePathExists = true;
            // dlg.EnsureReadOnly = false;
            // dlg.EnsureValidNames = true;
            // dlg.Multiselect = false;
            //dlg.ShowPlacesList = true;

            // if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            // {
            //     var folder = dlg.FileName;
            //     Debug.Print(folder);
            // }

            SelectDriveWindow driveWindow = new SelectDriveWindow();
            driveWindow.Show();

            string selectedDrive = driveWindow.SelectedDrivePath;
            if (selectedDrive != null)
            {

            }
        }

        void FileMenu_SelectClipsFolder_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.ShowDialog();
        }

        private void FileMenu_Settings_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FileMenu_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
