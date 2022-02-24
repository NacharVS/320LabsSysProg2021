using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace AsyncDataShow
{
    public partial class MainWindow : Window
    {
        public int count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Show_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => AddToList());
        }

        public string GetString(int n)
        {
            return $"Random thing number {n}";
        }

        private void AddToList()
        {
            Random rnd = new Random();
            count = rnd.Next(1, 30);
            MessageBox.Show($"Your number is {count}. Please, wait till the end");

            for (int i = 1; i <= count; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    TextList.Text += (GetString(i)+ "\n");
                }));
                Thread.Sleep(1000);
            }
            MessageBox.Show("The operation has been ended");
        }
    }
}
