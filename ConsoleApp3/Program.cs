using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program : UnitBattle
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Karen");
            warrior.HealthChangedEvent += ShowMessage;

            Warrior warrior2 = new Warrior("warrior2");
            warrior2.HealthChangedEvent += ShowMessage;

            Peasant peasant = new Peasant("Abdul");
            peasant.HealthChangedEvent += ShowMessage;

            Bishop bishop = new Bishop("Jora", 15);
            bishop.HealthChangedEvent += ShowMessage;

            Archer archer = new Archer("Kolya");
            archer.HealthChangedEvent += ShowMessage;

            UnitBattle.Fight(warrior, bishop);

        }

        // 1. create methods for inflict damage
        // 2. health value can not be less than 0
        //3*. Implement method heal of bishop class. 
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
