using System;
using System.Collections.Generic;
using System.Text;
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
using System.Threading.Tasks;

namespace ToChooseACleaner
{
    public partial class WorkPlacePage : Page
    {
        MongoClient client { get; set; }
        IMongoDatabase database { get; set; }
        public WorkPlacePage()
        {
            InitializeComponent();
            AddToMongo().GetAwaiter();
        }

        private async void Choose_Click(object sender, RoutedEventArgs e)
        {
            first.Text = "";
            second.Text = "";

            var rnd = new Random();
            var client = new MongoClient("mongodb://local");
            var database = client.GetDatabase("Stud");
            var collection = database.GetCollection<Entity>("Stud");
            var list = await collection.Find(x => true).ToListAsync();

            first.Text += (list[0].ListOfSubEntities[rnd.Next(0, 24)].SurnameOfSubEntity);
            second.Text += (list[0].ListOfSubEntities[rnd.Next(0, 24)].SurnameOfSubEntity);
        }

        public static async Task AddToMongo()
        {
            var client = new MongoClient("mongodb://local");
            var database = client.GetDatabase("Stud");
            var collection = database.GetCollection<Entity>("Stud");
            await collection.InsertOneAsync(MongoExamples.CreateEntity());
        }
    }
}
