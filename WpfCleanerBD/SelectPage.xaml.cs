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
	/// Логика взаимодействия для SelectPage.xaml
	/// </summary>
	public partial class SelectPage : Page
	{
		public SelectPage()
		{
			InitializeComponent();
			AddToMongo().GetAwaiter();
		}

		private void Select_Click(object sender, RoutedEventArgs e)
		{
			text_Cleaner.Text =  "";
			GetCleanFromMongo().GetAwaiter();
		}

		private void All_Click(object sender, RoutedEventArgs e)
		{
			text_All.Text  = "";
			GetAllFromMongo().GetAwaiter();
		}
		public static async Task AddToMongo()
		{
			var client = new MongoClient("mongodb://localhost");
			var database = client.GetDatabase("Cleaners320");
			var collection = database.GetCollection<Entity>("320");
			await collection.InsertOneAsync(MongoExamples.CreateEntity());
		}

		public async Task GetCleanFromMongo()
		{
			var rnd = new Random();
			var client = new MongoClient("mongodb://localhost");
			var database = client.GetDatabase("Cleaners320");
			var collection = database.GetCollection<Entity>("320");
			var list = await collection.Find(x => true).ToListAsync();

			text_Cleaner.Text += (list[0].ListOfSubEntities[rnd.Next(0, 24)].NameOfSubEntity + "\n");
			text_Cleaner.Text += (list[0].ListOfSubEntities[rnd.Next(0, 24)].NameOfSubEntity + "\n");
		}
		public async Task GetAllFromMongo()
		{
			var client = new MongoClient("mongodb://localhost");
			var database = client.GetDatabase("Cleaners320");
			var collection = database.GetCollection<Entity>("320");
			var list = await collection.Find(x => true).ToListAsync();
				for (int i = 0; i < 25; i++)
				{
					text_All.Text += (list[0].ListOfSubEntities[i].SurnameOfSubEntity + " " + list[0].ListOfSubEntities[i].NameOfSubEntity + "\n");
				}
		}
	}
}
