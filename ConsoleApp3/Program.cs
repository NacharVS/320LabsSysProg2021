using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Karen");
            warrior.HealthChangedEvent += ShowMessage;

            Peasant peasant = new Peasant("Abdul");
            peasant.HealthChangedEvent += ShowMessage;

            Bishop bishop = new Bishop("Jora", 15);
            bishop.HealthChangedEvent += ShowMessage;

            Archer archer = new Archer("Kolya");
            archer.HealthChangedEvent += ShowMessage;
            archer.Attack(warrior);

        }

        private static void Archer_HealthChangedEvent(string message)
        {
            throw new NotImplementedException();
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
