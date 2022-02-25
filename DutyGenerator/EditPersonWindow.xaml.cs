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
using System.Windows.Shapes;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DutyGenerator
{
    /// <summary>
    /// Логика взаимодействия для EditPersonWindow.xaml
    /// </summary>
    public partial class EditPersonWindow : Window
    {
        public List<Student> Students;
        public EditPersonWindow()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Group");
            var collection = database.GetCollection<Student>("320Group");
            Students = collection.Find(x => true).ToList();
        }
    }
}
