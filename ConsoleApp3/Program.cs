using ConsoleApp3.Buildings;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Bob");
            Archer archer = new Archer("Dod");
            warrior.HealthChandgedEvent += ShowMessage;
            archer.HealthChandgedEvent += ShowMessage;

            Battle battle = new Battle(warrior, archer, 6);
            battle.DistanceChangeEvent += ShowMessage;
            battle.Fight();
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
