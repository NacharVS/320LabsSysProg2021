using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Karen", 100, 20, 120);
            warrior.HealthChangedEvent += ShowMessage;

            Warrior warrior2 = new Warrior("warrior2", 100, 20, 120);
            warrior2.HealthChangedEvent += ShowMessage;

            Peasant peasant = new Peasant("Abdul", 70, 20, 10);
            peasant.HealthChangedEvent += ShowMessage;

            Bishop bishop = new Bishop("Jora", 80, 25);
            bishop.HealthChangedEvent += ShowMessage;

            Archer archer = new Archer("Kolya", 120, 20, 130);
            archer.HealthChangedEvent += ShowMessage;

            UnitBattle.Fight(warrior, archer);

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
