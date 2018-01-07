using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EAPWpfHandsOn
{
    public partial class MainWindow
    {
        private void StartDownloadButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleEnabledStateOfStartButton();
            string file = (DownloadFile.SelectedItem as ComboBoxItem)?.Content?.ToString();
            if (string.IsNullOrEmpty(file))
            {
                PrintLogMessage("No file chosen, please try again!");
                ToggleEnabledStateOfStartButton();
            }
            else
            {
                PrintLogMessage("Starting download of file:");
                PrintLogMessage(file);

                // Do download...
                var downloadHelper = new DownloadHelper();
                try
                {
                    int fileSize = downloadHelper.Download(file);

                    PrintLogMessage("Download completed!");
                    PrintLogMessage($"File Size was {fileSize}");                    
                }
                catch (Exception ex)
                {
                    PrintLogMessage("Download failed, error was:");
                    PrintLogMessage(ex.Message);
                }                
                finally
                {
                    ToggleEnabledStateOfStartButton();
                }
            }

            PrintLogMessage("\n");
        }
    }
}
