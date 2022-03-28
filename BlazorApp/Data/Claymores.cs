using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Claymore
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string BaseAttack { get; set; }
        public string SubstatBonus { get; set; }

        public static List<Claymore> GetClaymores()
        {
            List<Claymore> claymoreList = new List<Claymore>()
            {
                new Claymore()
                {
                    Name = "Wolf's Gravestone",
                    Image = "Images/Wolf's_Gravestone.png",
                    BaseAttack = "46(608)",
                    SubstatBonus = "ATK 10,8% (49,6%)"
                },
                new Claymore()
                {
                    Name = "Redhorn Stonethresher",
                    Image = "Images/Redhorn_Stonethresher.png",
                    BaseAttack = "44(542)",
                    SubstatBonus = "CRIT DMG 19.2% (88.2%)"
                },
                new Claymore()
                {
                    Name = "The Unforged",
                    Image = "Images/The_Unforged.png",
                    BaseAttack = "46 (608)",
                    SubstatBonus = "ATK 10.8% (49.6%)"
                },
                new Claymore()
                {
                    Name = "Song of Broken pines",
                    Image = "Images/Song_of_Broken_Pines.png",
                    BaseAttack = "49 (741)",
                    SubstatBonus = "Physical DMG Bonus 4.5% (20.7%)"
                },
                new Claymore()
                {
                    Name = "Skyward Pride",
                    Image = "Images/Skyward_Pride.png",
                    BaseAttack = "48 (674)",
                    SubstatBonus = "Energy Recharge 8% (36.8%)"
                },
                new Claymore()
                {
                    Name = "Whiteblind",
                    Image = "Images/Whiteblind.png",
                    BaseAttack = "42 (510)",
                    SubstatBonus = "DEF 11.3% (51.7%)"
                },
                new Claymore()
                {
                    Name = "The Bell",
                    Image = "Images/The_Bell.png",
                    BaseAttack = "42 (510)",
                    SubstatBonus = "HP 9% (41.3%)"
                },
                new Claymore()
                {
                    Name = "Snow-Tombed Starsilver",
                    Image = "Images/Snow-Tombed_Starsilver.png",
                    BaseAttack = "44 (565)",
                    SubstatBonus = "Physical DMG Bonus 7.5% (34.5%)"
                },
                new Claymore()
                {
                    Name = "Serpent Spine",
                    Image = "Images/Serpent_Spine.png",
                    BaseAttack = "42 (510)",
                    SubstatBonus = "CRIT Rate 6% (27.6%)"
                },
                new Claymore()
                {
                    Name = "Sacrificial Greatsword",
                    Image = "Images/Sacrificial_Greatsword.png",
                    BaseAttack = "44 (565)",
                    SubstatBonus = "Energy Recharge 6.7% (30.6%)"
                },
                new Claymore()
                {
                    Name = "Blackcliff Slasher",
                    Image = "Images/Blackcliff_Slasher.png",
                    BaseAttack = "42 (510)",
                    SubstatBonus = "CRIT DMG 12% (55.1%)"
                },
                new Claymore()
                {
                    Name = "Akuoumaru",
                    Image = "Images/Akuoumaru.png",
                    BaseAttack = "42 (510)",
                    SubstatBonus = "ATK 9% (41.3%)"
                },
                new Claymore()
                {
                    Name = "Rainslasher",
                    Image = "Images/Rainslasher.png",
                    BaseAttack = "42 (510)",
                    SubstatBonus = "Elemental Mastery 36 (165)"
                },
                new Claymore()
                {
                    Name = "Prototype Archaic",
                    Image = "Images/Prototype_Archaic.png",
                    BaseAttack = "44 (565)",
                    SubstatBonus = "ATK 6% (27.6%)"
                },
                new Claymore()
                {
                    Name = "LuxuriousSea-Lord",
                    Image = "Images/Luxurious_Sea-Lord.png",
                    BaseAttack = "41 (454)",
                    SubstatBonus = "ATK 12% (55.1%)"
                },
            };

            return claymoreList;

        }

    }
}
