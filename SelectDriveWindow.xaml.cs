using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Dashcam_Viewer
{
    /// <summary>
    /// Interaction logic for SelectDriveWindow.xaml
    /// </summary>
    public partial class SelectDriveWindow : Window
    {
        public string SelectedDrivePath {  get; set; }

        private DispatcherTimer refreshTimer;

        public SelectDriveWindow()
        {
            InitializeComponent();
            refreshTimer = new DispatcherTimer();
            refreshTimer.Interval = TimeSpan.FromSeconds(2);
            refreshTimer.Tick += UpdateDrivesList;
            refreshTimer.Start();
        }

        private void UpdateDrivesList(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Debug.Print("Located Drives:");
            var removeableDrives = new List<DriveInfo>();
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    removeableDrives.Add(drive);
                }
            }
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            SelectedDrivePath = string.Empty;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
