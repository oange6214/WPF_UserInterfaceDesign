using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace BusyIndicatorControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            bgLongProcessdWorker.DoWork += BgLongProcessWorker_DoWork;
            bgLongProcessdWorker.ProgressChanged += BgLongProcessWorker_ProgressChanged;
            bgLongProcessdWorker.RunWorkerCompleted += BgLongProcessWorker_RunWorkerCompleted;
        }

        private void BgLongProcessWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            busyIndicator.ProgressValue = 0;
            busyIndicator.Visibility = Visibility.Collapsed;
        }

        private void BgLongProcessWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            if (!busyIndicator.IsVisible)
            {
                busyIndicator.Visibility = Visibility.Visible;
            }
            busyIndicator.ProgressValue = e.ProgressPercentage;
            busyIndicator.Text = e.UserState as string;
        }

        private void BgLongProcessWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                bgLongProcessdWorker.ReportProgress(i, "Please wait...\r\nLong Process is running...");
                Thread.Sleep(50);
            }
        }

        BackgroundWorker bgLongProcessdWorker = new()
        {
            WorkerReportsProgress = true
        };

        private void btnExecuteProcess_Click(object sender, RoutedEventArgs e)
        {
            if (!bgLongProcessdWorker.IsBusy)
            {
                bgLongProcessdWorker.RunWorkerAsync();
            }
        }
    }
}
