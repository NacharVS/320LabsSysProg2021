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

namespace WpfTimerPeople
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task FillAsync(List<string> people, ListBox list)
        {
            await Task.Run(() => Fill(list, people));
        }

        static void Fill(ListBox listbox, List<string> lst)
        {
            foreach (var item in lst)
            {
                Thread.Sleep(500);
                listbox.Items.Add(item);
            }
        }

        public async Task AddItemAsync(List<string> people, ListBox list)
        {
            await Task.Run(() =>
            {
                Dispatcher.Invoke((Action)(() => AddItem(people, list)));
            });
        }

        static void AddItem(List<string> people, ListBox list)
        {
            Random random = new Random();


            Thread.Sleep(1000);
            var rnd = people.Count - 1;
            people.Add(people[random.Next(0, rnd)]);
            list.Items.Add(people[people.Count - 1]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _ = AddItemAsync(people, PeopleList);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //FillAsync(PeopleList, people);
        }
    }
}
