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
using System.Windows.Shapes;

namespace WPFAsyncTask
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        MongoClient client { get; set; }
        IMongoDatabase database { get; set; }
        Student student;
        public Edit(Student stud)
        {
            InitializeComponent();

            student = stud;

            client = new MongoClient("mongodb://localhost");
            database = client.GetDatabase("StudentData");
            this.DataContext = this;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var collection = database.GetCollection<Student>("Students");
            var definition1 = Builders<Student>.Update.Set(x => x.FirstName, tb_First.Text);
            var definition2 = Builders<Student>.Update.Set(x => x.LastName, tb_Last.Text);
            await collection.UpdateOneAsync(x => x.FirstName == student.FirstName, definition1);
            await collection.UpdateOneAsync(x => x.LastName == student.LastName, definition2);

            Close();
        }

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            var collection = database.GetCollection<Student>("Students");
            var filter = Builders<Student>.Filter.Eq("FirstName", student.FirstName);
            await collection.DeleteOneAsync(filter);

            Close();
        }
    }
}
