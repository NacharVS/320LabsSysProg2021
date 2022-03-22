﻿using System;
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



namespace WpfCleanerBD
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			frame_Select.NavigationService.Navigate(new SelectPage());
		}
        public static async Task AddToMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Cleaners320");
            var collection = database.GetCollection<Entity>("320");
            await collection.InsertOneAsync(MongoExamples.CreateEntity());
        }

        public static async Task GetAllFromMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Cleaners320");
            var collection = database.GetCollection<Entity>("320");
            var list = await collection.Find(x => true).ToListAsync();

            foreach (var item in list)
            {
                System.Console.WriteLine($"{item.Name}");
            }
        }


    }
}