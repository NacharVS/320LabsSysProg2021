using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Randomize
{
    public class DB
    {
        public DB(string nameOfSubEntity, string surnameOfSubEntity)
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
            ListOfSubEntities = new List<DB>();
        }

        public ObjectId _id { get; set; }
        public string NameOfEntity { get; set; }
        public string SurnameOfSubEntity { get; set; }
        public List<DB> ListOfSubEntities { get; set; }
    }
    public static class MongoExamples
    {
        public static Entity CreateEntity()
        {
            DB sub1 = new DB("Салават", "Абраров");
            DB sub2 = new DB("Владимир", "Аввакумов");
            DB sub3 = new DB("Егор", "Артемьев");
            DB sub4 = new DB("Антон", "Ахтямов");
            DB sub5 = new DB("Эмиль", "Барышев");
            DB sub6 = new DB("Андрей", "Бозин");
            DB sub7 = new DB("Линар", "Валиев");
            DB sub8 = new DB("Даниил", "Гаврилов");
            DB sub9 = new DB("Камиля", "Закирова");
            DB sub10 = new DB("София", "Кумышбаева");
            DB sub11 = new DB("Данис", "Мавлин");
            DB sub12 = new DB("Иван", "Мамонов");
            DB sub13 = new DB("Михаил", "Мясников");
            DB sub14 = new DB("Гузель", "Насуртдинова");
            DB sub15 = new DB("Клементий", "Николаев");
            DB sub16 = new DB("Андрей", "Тимофеев");
            DB sub17 = new DB("Гульназ", "Тухватуллина");
            DB sub18 = new DB("Даниль", "Фахрутдинов");
            DB sub19 = new DB("Адель", "Хайруллин");
            DB sub20 = new DB("Владислав", "Чийпеш");
            DB sub21 = new DB("Зиля", "Шагиахметова");
            DB sub22 = new DB("Айнур", "Шакиров");
            DB sub23 = new DB("Искандер", "Шарафеев");
            DB sub24 = new DB("Артем", "Сематкин");
            DB sub25 = new DB("Дияр", "Яппаров");

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
