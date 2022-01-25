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
                int timer1Time = int.Parse(tbTimer1Set.Text);
                int timer2Time = int.Parse(tbTimer2Set.Text);

                await Task.Run(() => StartTimer(timer1Time, tbTimer1Value));
                await Task.Run(() => StartTimer(timer2Time, tbTimer2Value));
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }
        }

        private void btnPar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int timer1Time = int.Parse(tbTimer1Set.Text);
                int timer2Time = int.Parse(tbTimer2Set.Text);

                while (timer1Time > 0 || timer2Time > 0)
                {
                    if (timer1Time > 0)
                    {
                        --timer1Time;
                    }
                    if (timer2Time > 0)
                    {
                        --timer2Time;
                    }

                    tbTimer1Value.Text = timer1Time.ToString();
                    tbTimer2Value.Text = timer2Time.ToString();
                    Thread.Sleep(1000);
                }

                MessageBox.Show("Таймеры завершили работу");
            }
            catch
            {
                MessageBox.Show("Введены не числа");
            }
        }

        public static void StartTimer(int time, TextBlock textBlock)
        {
            while (time > 0)
            {
                textBlock.Text = time.ToString();
                --time;
                Thread.Sleep(1000);
            }
        }
    }
}
