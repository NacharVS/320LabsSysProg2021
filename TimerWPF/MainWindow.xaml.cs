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
using System.Windows.Threading;

namespace TimerWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnSuc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int timerTime = int.Parse(tbTimerSet.Text);
                while (timerTime > 0)
                {
                    --timerTime;

                    string time = timerTime.ToString();
                    if (time.Length == 1)
                        tbTimerValue.Text = $"00:00:0{time}";
                    else if (time.Length == 2)
                        tbTimerValue.Text = $"00:00:{time}";

                    Thread.Sleep(1000);
                }
                MessageBox.Show("Таймер завершил работу");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не числовое значение");
            }
        }

        private async void btnPar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int timerTime = int.Parse(tbTimerSet.Text);
                await Task.Run(() => StartTimer(timerTime));
                MessageBox.Show("Таймер завершил работу");
            }
            catch
            {
                MessageBox.Show("Введены не числа");
            }
        }

        public void StartTimer(int timerTime)
        {
            while (timerTime > 0)
            {
                --timerTime;

                Dispatcher.Invoke((Action)(() =>
                {
                    string time = timerTime.ToString();
                    if (time.Length == 1)
                        tbTimerValue.Text = $"00:00:0{time}";
                    else if (time.Length == 2)
                        tbTimerValue.Text = $"00:00:{time}";
                }));

                Thread.Sleep(1000);
            }
        }
    }
}
