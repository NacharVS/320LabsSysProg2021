using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Group { get; set; }


        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                 new Student { FirstName = "Kenneth ", LastName = "Hopkins", Group = "11232"  },
                 new Student { FirstName = "Stephen ", LastName = "Thompson", Group = "2313123" },
                 new Student { FirstName = "Dwayne ", LastName = "Jackson", Group = "123132" },
                 new Student { FirstName = "JesGlen ", LastName = "Mooresi", Group = "3454535" },
                 new Student { FirstName = "Timothy ", LastName = "Murphy", Group = "1312313"},
            };

            return students;
        }
    }
}