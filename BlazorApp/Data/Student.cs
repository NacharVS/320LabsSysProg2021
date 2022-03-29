using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Group { get; set; }


        public static List<Student> GetStudentsGroup1()
        {
            List<Student> students = new List<Student>()
            {
                 new Student { FirstName = "Kenneth ", LastName = "Hopkins", Group = "111"  },
                 new Student { FirstName = "Stephen ", LastName = "Thompson", Group = "111" },
                 new Student { FirstName = "Dwayne ", LastName = "Jackson", Group = "111" },
                 new Student { FirstName = "Jes", LastName = "Mooresi", Group = "111" },
                 new Student { FirstName = "Timothy ", LastName = "Murphy", Group = "111"},
            };

            return students;
        }

        public static List<Student> GetStudentsGroup2()
        {
            List<Student> students = new List<Student>()
            {
                 new Student { FirstName = "Jeffrey", LastName = "Reyes", Group = "222"  },
                 new Student { FirstName = "Lawrence", LastName = "Johnson", Group = "222" },
                 new Student { FirstName = "Jacob", LastName = "Simpson", Group = "222" },
                 new Student { FirstName = "James", LastName = "McCoy", Group = "222" },
                 new Student { FirstName = "Anthony", LastName = "Osborne", Group = "222"},
            };

            return students;
        }
    }
}
