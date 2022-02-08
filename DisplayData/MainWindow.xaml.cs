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

namespace DisplayData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            for (int i =0; i<5; i++)
            {
                await Task.Delay(1000);
                Dispatcher.Invoke(() => Numbers.Items.Add(rnd.Next(10, 1000)));
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Numbers.Items.Clear();
        }
    }
}
