using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Warrior warrior = new Warrior("warrior1", 100, 20, 120, 10, 20);
            Peasant peasant = new Peasant("peasant1", 70, 20, 100);
            Warrior warrior2 = new Warrior("warrior2", 100, 15, 110, 5, 15);
            Catapult catapult = new Catapult("Шверер Густав", 1000, 100);
            Building building = new Building("Замок короля Артура", 10000);
            Archer archer = new Archer("archer", 120, 20, 130, 20, 30);
            peasant.HealthChangedEvent += ShowMessage;
            warrior.HealthChangedEvent += ShowMessage;
            warrior2.HealthChangedEvent += ShowMessage;
            building.HealthChangedEvent +=ShowMessage;
            Battle.Fight(warrior, warrior2);
            warrior.DamageUnit(peasant);
            Battle.Fight(building, catapult);
            Battle.Fight(archer, catapult);
            



        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
