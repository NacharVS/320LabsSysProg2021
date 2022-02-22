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
using MongoDB.Bson;
using MongoDB.Driver;

namespace WPFAsyncTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MongoClient client { get; set; }
        IMongoDatabase database { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost");
            database = client.GetDatabase("StudentData");
            this.DataContext = this;
        }

        private async void btnSelectClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var collection = database.GetCollection<Student>("Students");

                Random rnd = new Random();
                var students = new List<Student>();

                var list = await collection.Find(x => true).ToListAsync();

                for (int i = 0; i < 2; i++)
                {
                    int index = rnd.Next(0, list.Count());
                    students.Add(list[index]);
                    list.Remove(list[index]);
                }

                list_stud.ItemsSource = students;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private async void btnAddClick(object sender, RoutedEventArgs e)
        {
            var collection = database.GetCollection<Student>("Students");

            Student student = new Student
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text
            };

            await collection.InsertOneAsync(student);
            tbFirstName.Text = "";
            tbLastName.Text = "";
        }

        private void btnEditClick(object sender, RoutedEventArgs e)
        {
            EditStud editStud = new EditStud();

            editStud.ShowDialog();
        }
    }
}
