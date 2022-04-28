using System;
using System.Collections.Generic;

namespace AuthorizReg.Data
{
    public class Computer
    {
        public string Name { get; set; }
        public string Videocard { get; set; }
        public string CPU { get; set; }
        public string RAMCapacity { get; set; }
        public string ROMCapacity { get; set; }
        public string Price { get; set; }

        public Computer(string str)
        {
            string[] parameters = str.Split(';');
            int i = 0;
            Name = parameters[i++];
            Videocard = parameters[i++];
            CPU = parameters[i++];
            RAMCapacity = parameters[i++];
            ROMCapacity = parameters[i++];
            Price = parameters[i++];
        }

        public static List<Computer> GetRUComputers()
        {
            return new List<Computer>()
            {
                new Computer("PK1;RX 580 8гб;Ryzen 3 3100; 16 гб; 240 гб; 40000₽"),
                new Computer("PK2;GTX 1060 6 гб;Intel Core I5 10400F; 32 гб; 1 тб; 60000₽")
            };
                
        }

        public static List<Computer> GetENComputers()
        {
            return new List<Computer>()
            {
                new Computer("PK1;RX 580 8gb;Ryzen 3 3100; 16 gb; 240 gb; 400$"),
                new Computer("PK2;GTX 1060 6 gb;Intel Core I5 10400F; 32 gb; 1 tb; 600$")
            };

        }
    }
}
