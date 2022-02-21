using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSelectDuty
{
    public class DataBase
    {
        public DataBase(string nameOfSubEntity, string surnameOfSubEntity)
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
            ListOfSubEntities = new List<DataBase>();
        }

        public ObjectId _id { get; set; }
        public string NameOfEntity { get; set; }
        public string SurnameOfSubEntity { get; set; }
        public List<DataBase> ListOfSubEntities { get; set; }
    }
    public static class MongoExamples
    {
        public static Entity CreateEntity()
        {
            DataBase sub1 = new DataBase("Салават", "Абраров");
            DataBase sub2 = new DataBase("Владимир", "Аввакумов");
            DataBase sub3 = new DataBase("Егор", "Артемьев");
            DataBase sub4 = new DataBase("Антон", "Ахтямов");
            DataBase sub5 = new DataBase("Эмиль", "Барышев");
            DataBase sub6 = new DataBase("Андрей", "Бозин");
            DataBase sub7 = new DataBase("Линар", "Валиев");
            DataBase sub8 = new DataBase("Даниил", "Гаврилов");
            DataBase sub9 = new DataBase("Камиля", "Закирова");
            DataBase sub10 = new DataBase("София", "Кумышбаева");
            DataBase sub11 = new DataBase("Данис", "Мавлин");
            DataBase sub12 = new DataBase("Иван", "Мамонов");
            DataBase sub13 = new DataBase("Михаил", "Мясников");
            DataBase sub14 = new DataBase("Гузель", "Насуртдинова");
            DataBase sub15 = new DataBase("Клементий", "Николаев");
            DataBase sub16 = new DataBase("Андрей", "Тимофеев");
            DataBase sub17 = new DataBase("Гульназ", "Тухватуллина");
            DataBase sub18 = new DataBase("Даниль", "Фахрутдинов");
            DataBase sub19 = new DataBase("Адель", "Хайруллин");
            DataBase sub20 = new DataBase("Владислав", "Чийпеш");
            DataBase sub21 = new DataBase("Зиля", "Шагиахметова");
            DataBase sub22 = new DataBase("Айнур", "Шакиров");
            DataBase sub23 = new DataBase("Искандер", "Шарафеев");
            DataBase sub24 = new DataBase("Артем", "Сематкин");
            DataBase sub25 = new DataBase("Дияр", "Яппаров");

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
