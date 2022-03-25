using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public static List<User> GetUserList()
        {
            List<User> lis = new List<User>()
            {
                 new User { FirstName = "Frank", LastName = "Murphy", Email = "frank.murphy@test.com", Role = "User" },
                 new User { FirstName = "Vic", LastName = "Reynolds", Email = "vic.reynolds@test.com", Role = "Admin"},
                 new User { FirstName = "Gina", LastName = "Jabowski", Email = "gina.jabowski@test.com", Role = "Admin"},
                 new User { FirstName = "Jessi", LastName = "Glaser", Email = "jessi.glaser@test.com", Role = "User"},
                 new User { FirstName = "Jay", LastName = "Bilzerian", Email = "jay.bilzerian@test.com", Role = "User"},
            };

            return lis;
        }
    }
}
