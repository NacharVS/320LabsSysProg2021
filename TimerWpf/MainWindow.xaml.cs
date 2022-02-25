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

namespace TimerWpf
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

        private void ConsistStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i <= Convert.ToInt32(timeSec.Text); i++)
                {
                    CheckLength(i);
                    Thread.Sleep(1000);
                }
                MessageBox.Show("Время вышло!", "Всё решено, времени мало", MessageBoxButton.OKCancel);
            }
            catch
            {
                MessageBox.Show("Не ввели число!", "Введи ты уже число", MessageBoxButton.OKCancel);
            }
        }

        private async void AsyncStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(timeSec.Text);
                await Task.Run(() => TimeWait(time));
                MessageBox.Show("Время вышло!", "Всё решено, времени мало", MessageBoxButton.OKCancel);
            }
            catch
            {
                MessageBox.Show("Не ввели число!", "Введи ты уже число", MessageBoxButton.OKCancel);
            }
        }

        public void CheckLength(int i)
        {
            if (i.ToString().Length == 1)
                lbTime.Content = $"00:00:0{i.ToString()}";
            else if (i.ToString().Length == 2)
                lbTime.Content = $"00:00:{i.ToString()}";
        }

        public void TimeWait(int time)
        {
            for (int i = 0; i <= time; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    CheckLength(i);
                }));
                Thread.Sleep(1000);
            }
        }
    }
}
