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

namespace WpfCleanerBD
{
	/// <summary>
	/// Логика взаимодействия для AllPage.xaml
	/// </summary>
	public partial class AllPage : Page
	{
		public AllPage()
		{
			InitializeComponent();
            AddToMongo().GetAwaiter();
            GetAllFromMongo().GetAwaiter();
        }
        public static async Task AddToMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Cleaners320");
            var collection = database.GetCollection<Entity>("320");
            await collection.InsertOneAsync(MongoExamples.CreateEntity());
        }

        public async Task GetAllFromMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Cleaners320");
            var collection = database.GetCollection<Entity>("320");
            var list = await collection.Find(x => true).ToListAsync();

            foreach (var item in list)
            {
                for (int i = 0; i < 25; i++)
                {
                    text_Name.Text += (item.ListOfSubEntities[i].SurnameOfSubEntity + " " + item.ListOfSubEntities[i].NameOfSubEntity + "\n" );
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
