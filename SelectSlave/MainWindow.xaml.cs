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

namespace SelectSlave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MongoClient client { get; set; }
        IMongoDatabase database { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            client = new MongoClient("mongodb://localhost");
            database = client.GetDatabase("SlaveData");
            this.DataContext = this;
        }

        private async void btnSelectClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var collection = database.GetCollection<Slave>("Slaves");

                int slavesCount = int.Parse(tbSlavesCount.Text);
                int group = int.Parse(tbGroup.Text);

                var list = await collection.Find(x => x.IdGroup == group).ToListAsync();

                Random rnd = new Random();
                var slaves = new List<Slave>();

                for (int i = 0; i < slavesCount; i++)
                {
                    int index = rnd.Next(0, list.Count());
                    slaves.Add(list[index]);
                    list.Remove(list[index]);
                }

                lbSlaves.ItemsSource = slaves;
            }
            catch 
            {
                MessageBox.Show("АБЫБКА");
            }
           
        }

        private async void btnAddClick(object sender, RoutedEventArgs e)
        { 
            var collection = database.GetCollection<Slave>("Slaves");
            
            Slave slave = new Slave
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text ,
                IdGroup = int.Parse(tbNewGroup.Text)
            };

            await collection.InsertOneAsync(slave);
            await collection.ReplaceOneAsync(x => );
            tbFirstName.Text = "";
            tbLastName.Text = "";
        }
    }
}
