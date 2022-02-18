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

namespace Random
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
            //var rnd = Random;
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Random");
            var collection = database.GetCollection<Entity>("Random");
            var list = await collection.Find(x => true).ToListAsync();

            foreach (var item in list)
            {
                for (int i = 0; i <25; i++)
                {
                    txt_Name.Text += (item.ListOfSubEntities[i].SurnameOfSubEntity + "\n");
                }
            }
        }
        private void btn_rnd_Click(object sender, RoutedEventArgs e)
        {
            GetAllFromMongo().GetAwaiter();
        }
    }
}
