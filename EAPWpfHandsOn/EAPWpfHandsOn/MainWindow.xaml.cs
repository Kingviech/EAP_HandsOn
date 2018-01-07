using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace EAPWpfHandsOn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PrintLogMessage("Welcome to Amazing Download Helper v1.0!!!");
            PrintLogMessage("-------------------------------------------");
            PrintLogMessage("Please select a file to start the download.");
        }               

        private void PrintLogMessage(string message)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                DebugLog.Text += message + "\n";
                DebugLogScroller.ScrollToBottom();
            });
        }

        private void ToggleEnabledStateOfStartButton()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                StartDownloadButton.IsEnabled = !StartDownloadButton.IsEnabled;
            });
        }        
    }
}
