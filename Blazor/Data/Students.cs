using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Students
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Language { get; set; }


        public static List<Students> GetStudents()
        {
            List<Students> lis = new List<Students>()
            {
                 new Students { Name = "Данис", Surname = "Мавлин", Age = 18, Language = "Русский"},
                 new Students { Name = "Владимир", Surname = "Аввакумов", Age = 19, Language = "English"},
                 new Students { Name = "Антоха", Surname = "Чей-то", Age = 20, Language = "Украинский"},
                 new Students { Name = "Салават", Surname = "Абраров", Age = 16, Language = "Белоруский"},
                 new Students { Name = "Рудольф", Surname = "Победитель", Age = 15, Language = "English"},
                 new Students { Name = "Зиля", Surname = "Шагиахиетова", Age = 14, Language = "English"},
                 new Students { Name = "Прапор", Surname = "Васильков", Age = 12, Language = "Албанский"},
                 new Students { Name = "Аполинария", Surname = "Ландышева", Age = 19, Language = "English"},
            };

            return lis;
        }
    }
}
