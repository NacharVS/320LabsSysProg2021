using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Rumiya");
            Peasant peasant = new Peasant("Salavat");
            Archer archer = new Archer("Ainur");
            warrior.HealthChangeEvent += ShowFirst;
            archer.HealthChangeEvent += ShowSecond;
            archer.ShotsCountChangeEvent += ShowInfo;
            Battle battle = new Battle(warrior, archer, 100);
            battle.DistanceChangeEvent += ShowInfo;
            battle.Fight();
        }


        public static void ShowFirst(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mes);
        }
        
        public static void ShowSecond(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(mes);
        }

        public static void ShowInfo(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mes);
        }
    }
}
