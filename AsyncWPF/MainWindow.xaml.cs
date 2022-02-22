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
namespace AsyncWPF
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
        private Random _random = new Random(Environment.TickCount);

        public string RandomString(int length)
        {
            string chars = ";서후;ㄴ파뤼피'냐ㅜㅐㅍㄱ;ㄷㄹ갸ㅠㅍ;아ㅓ추ㅏ.너우;치ㅗㄴㄷ개;포ㅑㅐㅗюючлвмаивжгшявимобвт жмщышржаи жлыфагумшгжлаыи";
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);

            return builder.ToString();
        }

        private async void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => AddList());
        }

        private void AddList()
        {
            for (int i = 1; i <= 100; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    lv_phone.Items.Add(RandomString(i));
                }));
                Thread.Sleep(5000);
            }
        }
    }
}
