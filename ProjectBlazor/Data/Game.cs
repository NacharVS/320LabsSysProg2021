using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBlazor.Data
{
    public class Game
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public static List<Game> GetHomeCarList()
        {
            List<Game> lis = new List<Game>()
            {
                 new Game { Name = "Москвич", Model = "412", Price = 120000},
                 new Game { Name = "Lada", Model = "2106", Price = 200000},
            };

            return lis;
        }

        public static List<Game> GetEnglishCarList()
        {
            List<Game> lis = new List<Game>()
            {
                 new Game { Name = "Toyota", Model = "Corolla", Price = 1685000},
                 new Game { Name = "Kia", Model = "Ceed", Price = 1475000},
            };

            return lis;
        }
    }
}
