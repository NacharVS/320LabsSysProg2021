using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Bow
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string BaseAttack { get; set; }
        public string SubstatBonus { get; set; }

        public static List<Bow> GetBows()
        {
            List<Bow> bowList = new List<Bow>()
            {
                new Bow()
                {
                    Name = "Thundering Pulse",
                    Image = "Images/bowYeimia.png",
                    BaseAttack = "46(608)",
                    SubstatBonus = "CRIT DMG 14.4% (66.2%)"
                },
                new Bow()
                {
                    Name = "Elegy for the End",
                    Image = "Images/bowVienti.png",
                    BaseAttack = "46(608)",
                    SubstatBonus = "Energy Recharge 12% (55.1%)"
                },
                new Bow()
                {
                    Name = "Polar Star",
                    Image = "Images/bowTort.png",
                    BaseAttack = "46 (608)",
                    SubstatBonus = "CRIT Rate 7.2% (33.1%)"
                },
                new Bow()
                {
                    Name = "Skyward Harp",
                    Image = "Images/bowKrilo.png",
                    BaseAttack = "48 (674)",
                    SubstatBonus = "CRIT Rate 4.8% (22.1%)"
                },
                new Bow()
                {
                    Name = "Amos' Bow",
                    Image = "Images/bowKoza.png",
                    BaseAttack = "46 (608)",
                    SubstatBonus = "ATK 10.8% (49.6%)"
                }
            };

            return bowList;
        }

    }
}
