using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bogus;

namespace AsyncFillList
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            await Task.Run(() => CreatePigs());
        }

        private void CreatePigs()
        {
            Faker faker = new Faker("ru");
            var rnd = new Randomizer();
            for (int i = 1; i <= 100; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    lvPigs.Items.Add(new Pig(faker.Name.FirstName(), i));
                }));
                Thread.Sleep(rnd.Int(1, 3) * 500);
            }
        }
    }

    public class Pig
    {
        public string Name { get; set; }
        public double Age { get; set; }

        public Pig(string newName, double newAge)
        {
            Name = newName;
            Age = newAge;
        }

        public override string ToString()
        {
            return $"{Name} {Age}" + (Age > 8 ? " Зрелый" : "");
        }
    }
}
