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

namespace WpfTimer
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

        private async void Btn_async(object sender, RoutedEventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(txt_time.Text);
                await Task.Run(() => Timer(time));
                MessageBox.Show("Таймер всё");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }

        }

        private void Btn_roll(object sender, RoutedEventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(txt_time.Text);
                for (int i = 0; i <= time; i++)
                {
                    Thread.Sleep(1000);
                    if (i.ToString().Length == 1)
                        txt_timer.Content = $"{i}";
                    else if (i.ToString().Length == 2)
                        txt_timer.Content = $"{i}";
                }
                MessageBox.Show("Таймер всё");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }

        }

        public void Timer(int time)
        {
            for (int i = 0; i <= time; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    if (i.ToString().Length == 1)
                        txt_timer.Content = $"{i}";
                    else if (i.ToString().Length == 2)
                        txt_timer.Content = $"{i}";
                }));
                Thread.Sleep(1000);
            }
        }
    }
}
