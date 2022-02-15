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
using System.Threading.Tasks;

namespace WpfAppList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] listData = new string[10];
        public static int n = 0;
        public MainWindow()
        {
            InitializeComponent();
            listData[0] = "Hello!";
            listData[1] = "My name Petry";
            listData[2] = "I bern in 2010 year";
            listData[3] = "I have a sister and a brother";
            listData[4] = "I live with my mom and dad";
            listData[5] = "I like to play sports";
            listData[6] = "My favorite football game";
            listData[7] = "I really want to grow up and be a footballer";
            listData[8] = "And then I can get a lot of money";
            listData[9] = "Bye-Bye!";
        }

        private async void btn_data_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => AddList());
        }

        public string GetString()
        {
            var rnd = new Random();
            while (n < 10)
            {
                return listData[rnd.Next(0, 9)];
            }
            return "OK";
        }

        private void AddList()
        {
            for (int i = 1; i <= 100; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    txt_list.Text += (GetString() + "\n");
                }));
                Thread.Sleep(5000);
            }
        }
    }
}
