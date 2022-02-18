
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfCleanerBD
{
    public class SubEntity
    {
        public SubEntity(string nameOfSubEntity, string surnameOfSubEntity)
        {
            NameOfSubEntity = nameOfSubEntity;
            SurnameOfSubEntity = surnameOfSubEntity;
        }

        public string NameOfSubEntity { get; set; }
        public string SurnameOfSubEntity { get; set; }
    }
    public class Entity
    {
        public Entity(string nameOfEntity)
        {
            Name = nameOfEntity;
            ListOfSubEntities = new List<SubEntity>();
        }

        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public List<SubEntity> ListOfSubEntities { get; set; }
    }
    public class MongoExamples
    {
        public static Entity CreateEntity()
        {
            SubEntity sub1 = new SubEntity("Салават", "Абраров");
            SubEntity sub2 = new SubEntity("Владимир", "Аввакумов");
            SubEntity sub3 = new SubEntity("Егор", "Артемьев");
            SubEntity sub4 = new SubEntity("Антон", "Ахтямов");
            SubEntity sub5 = new SubEntity("Эмиль", "Барышев");
            SubEntity sub6 = new SubEntity("Андрей", "Бозин");
            SubEntity sub7 = new SubEntity("Линар", "Валиев");
            SubEntity sub8 = new SubEntity("Даниил", "Гаврилов");
            SubEntity sub9 = new SubEntity("Камиля", "Закирова");
            SubEntity sub10 = new SubEntity("София", "Кумышбаева");
            SubEntity sub11 = new SubEntity("Данис", "Мавлин");
            SubEntity sub12 = new SubEntity("Иван", "Мамонов");
            SubEntity sub13 = new SubEntity("Михаил", "Мясников");
            SubEntity sub14 = new SubEntity("Гузель", "Насуртдинова");
            SubEntity sub15 = new SubEntity("Клементий", "Николаев");
            SubEntity sub16 = new SubEntity("Андрей", "Тимофеев");
            SubEntity sub17 = new SubEntity("Гульназ", "Тухватуллина");
            SubEntity sub18 = new SubEntity("Даниль", "Фахрутдинов");
            SubEntity sub19 = new SubEntity("Адель", "Хайруллин");
            SubEntity sub20 = new SubEntity("Владислав", "Чийпеш");
            SubEntity sub21 = new SubEntity("Зиля", "Шагиахметова");
            SubEntity sub22 = new SubEntity("Айнур", "Шакиров");
            SubEntity sub23 = new SubEntity("Искандер", "Шарафеев");
            SubEntity sub24 = new SubEntity("Артем", "Сематкин");
            SubEntity sub25 = new SubEntity("Дияр", "Яппаров");

            Entity entity1 = new Entity("320");
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