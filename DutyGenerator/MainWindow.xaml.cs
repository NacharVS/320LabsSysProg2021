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
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace DutyGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> Students { get; set; }
        public MainWindow()
        {
            //MongoExamples.AddToMongo().GetAwaiter();
            
            InitializeComponent();
            MongoExamples.AddToMongo(new Student() { FirstName = "Михаил", LastName = "Бозин" }).GetAwaiter();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Group");
            var collection = database.GetCollection<Student>("320Group");
            var list = await collection.Find(x => true).ToListAsync();
            var rnd = new Random();
            var first = rnd.Next(0, 18);
            
            FirstStudent.Text = $"{list[first].FirstName} {list[first].LastName}";
            list.RemoveAt(first);

            var second = rnd.Next(0, 17);
            SecondStudent.Text = $"{list[second].FirstName} {list[second].LastName}";
        }
    }

    public class Student
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class MongoExamples
    {

        public static async Task AddToMongo(Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Group");
            var collection = database.GetCollection<Student>("320Group");
            //await collection.InsertOneAsync(student);
            await collection.ReplaceOneAsync(new BsonDocument("FirstName", "Михаил"), student);
        }
    }
}
