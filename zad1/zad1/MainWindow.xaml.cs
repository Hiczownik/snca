using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace zad1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
 private readonly DispatcherTimer _timer;
        private readonly Stopwatch _stopwatch;
        private readonly ObservableCollection<string> _lapTimes;

        public MainWindow()
        {
            InitializeComponent();
            
            _lapTimes = new ObservableCollection<string>();
            LapList.ItemsSource = _lapTimes;
            
            _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(10) };
            _timer.Tick += Timer_Tick;
            
            _stopwatch = new Stopwatch();
            UpdateTimeDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            TimeDisplay.Text = FormatTime(_stopwatch.Elapsed);
        }

        private static string FormatTime(TimeSpan time)
        {
            return $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds / 10:00}";
        }

        private void StartStop_Click(object sender, RoutedEventArgs e)
        {
            if (_stopwatch.IsRunning)
            {
                _stopwatch.Stop();
                _timer.Stop();
                StartStopButton.Content = "Start";
                LapButton.IsEnabled = false;
            }
            else
            {
                _stopwatch.Start();
                _timer.Start();
                StartStopButton.Content = "Stop";
                LapButton.IsEnabled = true;
            }
        }

        private void Lap_Click(object sender, RoutedEventArgs e)
        {
            _lapTimes.Add($"Międzyczas {_lapTimes.Count + 1}: {FormatTime(_stopwatch.Elapsed)}");
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _stopwatch.Reset();
            _lapTimes.Clear();
            _timer.Stop();
            StartStopButton.Content = "Start";
            LapButton.IsEnabled = false;
            UpdateTimeDisplay();
        }
}