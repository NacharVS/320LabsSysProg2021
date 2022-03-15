using MongoDB.Bson;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DutyProject
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

        static Entity CreateEntity()
        {
            SubEntity sub1 = new SubEntity("Guzel", "Nasurtdinova");
            SubEntity sub2 = new SubEntity("Zilya", "Shagiahmetova");
            SubEntity sub3 = new SubEntity("Sofia", "Cumishbaeva");

            Entity entity1 = new Entity("GroupEntity", "Test");
            entity1.ListOfSubEntities.Add(sub1);
            entity1.ListOfSubEntities.Add(sub2);
            entity1.ListOfSubEntities.Add(sub3);

            return entity1;
        }

        public static async Task AddToMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320GroupTest");
            var collection = database.GetCollection<Entity>("TestEntities");
            await collection.InsertOneAsync(CreateEntity());
        }
    }
    class SubEntity
    {
        public SubEntity(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Entity
    {
        public Entity(string nameOfEntity, string numberOfEntity)
        {
            Name = nameOfEntity;
            Surname = numberOfEntity;
            ListOfSubEntities = new List<SubEntity>();
        }

        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<SubEntity> ListOfSubEntities { get; set; }
    }
}
