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

namespace TimerWPF
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

        private void btnParallelStart_Click(object sender, RoutedEventArgs e)
        {
            timer1Time.Text = "weaggggggg";
            Task timer1 = new Task(() => StartTimerAsync(10, "timer1", 0, timer1Time));
            Task timer2 = new Task(() => StartTimerAsync(10, "timer2", 0, timer2Time));
            timer1.Start();
            timer2.Start();
            StartTimerAsync(10, "timer1", 0, timer1Time);
        }

        private void btnSequentiallyStart_Click(object sender, RoutedEventArgs e)
        {

        }
        private static void StartTimer(int time, string timer, int delayTime, TextBlock textBlock)
        {
            Thread.Sleep(delayTime * 1000);
            while (time > 0)
            {
                textBlock.Text = $"{timer} {time}";
                Thread.Sleep(1000);
                time--;
            }

            textBlock.Text = $"{timer} Время закончилось";
        }
        private static async void StartTimerAsync(int time, string timer, int delayTime, TextBlock textBlock)
        {
            await Task.Run(() => StartTimer(time, timer, delayTime, textBlock));
        }
    }
}
