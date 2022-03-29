using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppLists2.Data
{
    public class Anime
    {
        public string Img { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string CountSeries { get; set; }
        public static List<Anime> GetAnimes()
        {
            List<Anime> animes = new List<Anime>()
            {
                new Anime()
                {
                    Img = "img/Levi.png",
                    Name = "Attack on titan",
                    Date = "13/03/2003",
                    CountSeries = "94"
                },
                new Anime()
                {
                    Img = "img/Levi.png",
                    Name = "Attack on titan",
                    Date = "13/03/2003",
                    CountSeries = "94"
                },
                new Anime()
                {
                    Img = "img/Levi.png",
                    Name = "Attack on titan",
                    Date = "13/03/2003",
                    CountSeries = "94"
                },
                new Anime()
                {
                    Img = "img/Levi.png",
                    Name = "Attack on titan",
                    Date = "13/03/2003",
                    CountSeries = "94"
                },
                new Anime()
                {
                    Img = "img/Levi.png",
                    Name = "Attack on titan",
                    Date = "13/03/2003",
                    CountSeries = "94"
                },
                new Anime()
                {
                    Img = "img/Levi.png",
                    Name = "Attack on titan",
                    Date = "13/03/2003",
                    CountSeries = "94"
                }
            };
            return animes;
        }
    }
}
