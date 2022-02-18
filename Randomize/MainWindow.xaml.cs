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

namespace Randomize
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddToMongo().GetAwaiter();
        }

        public static async Task AddToMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Random");
            var collection = database.GetCollection<Entity>("Random");
            await collection.InsertOneAsync(MongoExamples.CreateEntity());
        }

        public async Task GetAllFromMongo()
        {
            var rnd = new Random();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Random");
            var collection = database.GetCollection<Entity>("Random");
            var list = await collection.Find(x => true).ToListAsync();

            txt_Name.Text += (list[0].ListOfSubEntities[rnd.Next(0, 24)].SurnameOfSubEntity + "\n");
            txt_Name.Text += (list[0].ListOfSubEntities[rnd.Next(0, 24)].SurnameOfSubEntity + "\n");

        }
        private void btn_rnd_Click(object sender, RoutedEventArgs e)
        {
            txt_Name.Text = "";
            GetAllFromMongo().GetAwaiter();
        }
    }
}
