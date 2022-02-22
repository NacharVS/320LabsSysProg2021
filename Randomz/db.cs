using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


namespace Randomz
{
    class db
    {
        public void Edit(Entity entity)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students320");
            var collection = database.GetCollection<Entity>("Students320");
            collection.ReplaceOne(x => x.NameOfEntity == "Ivan", entity);
        }
        public db(string nameOfSubEntity, string surnameOfSubEntity)
        {
            NameOfSubEntity = nameOfSubEntity;
            SurnameOfSubEntity = surnameOfSubEntity;
        }

        public string NameOfSubEntity { get; set; }
        public string SurnameOfSubEntity { get; set; }
    }


    public class Entity
    {
        public Entity(string nameOfEntity, string surnameOfSubEntity)
        {
            NameOfEntity = nameOfEntity;
            SurnameOfSubEntity = surnameOfSubEntity;
            ListOfSubEntities = new List<db>();
        }
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string NameOfEntity { get; set; }
        public string SurnameOfSubEntity { get; set; }
        public List<db> ListOfSubEntities { get; set; }
    }
    public static class MongoExamples
    {
        public static Entity CreateEntity()
        {
            db sub1 = new db("Салават", "Абраров");
            db sub2 = new db("Владимир", "Аввакумов");
            db sub3 = new db("Егор", "Артемьев");
            db sub4 = new db("Антон", "Ахтямов");
            db sub5 = new db("Эмиль", "Барышев");
            db sub6 = new db("Андрей", "Бозин");
            db sub7 = new db("Линар", "Валиев");
            db sub8 = new db("Даниил", "Гаврилов");
            db sub9 = new db("Камиля", "Закирова");
            db sub10 = new db("София", "Кумышбаева");
            db sub11 = new db("Данис", "Мавлин");
            db sub12 = new db("Иван", "Мамонов");
            db sub13 = new db("Михаил", "Мясников");
            db sub14 = new db("Гузель", "Насуртдинова");
            db sub15 = new db("Клементий", "Николаев");
            db sub16 = new db("Андрей", "Тимофеев");
            db sub17 = new db("Гульназ", "Тухватуллина");
            db sub18 = new db("Даниль", "Фахрутдинов");
            db sub19 = new db("Адель", "Хайруллин");
            db sub20 = new db("Владислав", "Чийпеш");
            db sub21 = new db("Зиля", "Шагиахметова");
            db sub22 = new db("Айнур", "Шакиров");
            db sub23 = new db("Искандер", "Шарафеев");
            db sub24 = new db("Артем", "Сематкин");
            db sub25 = new db("Дияр", "Яппаров");

            Entity entity1 = new Entity("AlphaEntity", "");
            entity1.ListOfSubEntities.Add(sub1);
            entity1.ListOfSubEntities.Add(sub2);
            entity1.ListOfSubEntities.Add(sub3);
            entity1.ListOfSubEntities.Add(sub4);
            entity1.ListOfSubEntities.Add(sub5);
            entity1.ListOfSubEntities.Add(sub6);
            entity1.ListOfSubEntities.Add(sub7);
            entity1.ListOfSubEntities.Add(sub8);
            entity1.ListOfSubEntities.Add(sub9);
            entity1.ListOfSubEntities.Add(sub10);
            entity1.ListOfSubEntities.Add(sub11);
            entity1.ListOfSubEntities.Add(sub12);
            entity1.ListOfSubEntities.Add(sub13);
            entity1.ListOfSubEntities.Add(sub14);
            entity1.ListOfSubEntities.Add(sub15);
            entity1.ListOfSubEntities.Add(sub16);
            entity1.ListOfSubEntities.Add(sub17);
            entity1.ListOfSubEntities.Add(sub18);
            entity1.ListOfSubEntities.Add(sub19);
            entity1.ListOfSubEntities.Add(sub20);
            entity1.ListOfSubEntities.Add(sub21);
            entity1.ListOfSubEntities.Add(sub22);
            entity1.ListOfSubEntities.Add(sub23);
            entity1.ListOfSubEntities.Add(sub24);
            entity1.ListOfSubEntities.Add(sub25);
            return entity1;
        }
    }
}
