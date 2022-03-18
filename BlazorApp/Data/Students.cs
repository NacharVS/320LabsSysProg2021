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
                 new Students { Name = "Иван", Surname = "Мамонов", Age = 18, Language = "Русский"},
                 new Students { Name = "Даниил", Surname = "Гаврилов", Age = 19, Language = "English"},
                 new Students { Name = "Маруся", Surname = "Ивановна", Age = 20, Language = "Украинский"},
                 new Students { Name = "Салават", Surname = "Абраров", Age = 16, Language = "Белоруский"},
                 new Students { Name = "Егор", Surname = "Артемьев", Age = 15, Language = "English"},
                 new Students { Name = "Зиля", Surname = "Шагиахиетова", Age = 14, Language = "English"},
                 new Students { Name = "Миша", Surname = "Ельцин", Age = 12, Language = "Албанский"},
                 new Students { Name = "Володя", Surname = "Аввакумов", Age = 19, Language = "English"},
            };

            return lis;
        }
    }
}
