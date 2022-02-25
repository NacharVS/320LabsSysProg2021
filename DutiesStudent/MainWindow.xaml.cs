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

namespace DutiesStudent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student student;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students320");
            var collection = database.GetCollection<Student>("TestStudents");
            var list = await collection.Find(x => true).ToListAsync();
            var rnd = new Random();
            var first = rnd.Next(0, 18);

            FirstStudent.Text = $"{list[first].Name} {list[first].Surname}";
            list.RemoveAt(first);

            var second = rnd.Next(0, 17);
            SecondStudent.Text = $"{list[second].Name} {list[second].Surname}";
        }

        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbStudents.SelectedItem as Student != null)
            {
                student = lbStudents.SelectedItem as Student;

                tbFirstName.Text = student.Name;
                tbLastName.Text = student.Surname;
            }
        }

        private async void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students320");
            var collection = database.GetCollection<Student>("TestStudents");


            var filter = Builders<Student>.Filter.Eq("_id", student._id);
            var updateName = Builders<Student>.Update.Set(x => x.Name, tbFirstName.Text);
            var updateSurname = Builders<Student>.Update.Set(x => x.Surname, tbLastName.Text);
            collection.UpdateOne(filter, updateSurname);
            collection.UpdateOne(filter, updateName);
            lbStudents.ItemsSource = await collection.Find(x => true).ToListAsync();
            MessageBox.Show("Студент переименоват");
        }

        private async void btnFillList_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students320");
            var collection = database.GetCollection<Student>("TestStudents");
            var list = await collection.Find(x => true).ToListAsync();
            var rnd = new Random();
            var first = rnd.Next(0, 18);

            lbStudents.ItemsSource = list;
        }
    }
}
