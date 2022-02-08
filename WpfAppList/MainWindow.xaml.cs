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

        private void btn_data_Click(object sender, RoutedEventArgs e)
        {
            GetList().GetAwaiter();
        }

        async Task GetList()
        {
            await Task.Run(() => RndString());
        }

        void RndString()
        {
            var rnd = new Random();
            while (n < 10)
            {
                Thread.Sleep(rnd.Next(10000, 40000));
                txt_list.Text = listData[n];
            }
        }
    }
}
