using MongoDB.Driver;
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

namespace WPFAsyncTask
{
    /// <summary>
    /// Interaction logic for EditStud.xaml
    /// </summary>
    public partial class EditStud : Window
    {
        MongoClient client { get; set; }
        IMongoDatabase database { get; set; }
        public EditStud()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost");
            database = client.GetDatabase("StudentData");


            var collection = database.GetCollection<Student>("Students");
            var students = new List<Student>();
            var list = collection.Find(x => true).ToList();

            for (int i = 0; i < list.Count(); i++)
            {
                students.Add(list[i]);
                list.Remove(list[i]);
            }

            list_std.ItemsSource = students;

            this.DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var info = (sender as ListView).SelectedItem as Student;

            Edit page = new Edit(info);

            page.ShowDialog();

            Close();
        }
    }
}
