using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(100, 50);
            warrior.HealthChangedEvent += ShowMessage;
            Peasant peasant = new Peasant();
            peasant.HealthChangedEvent += ShowMessage;
            Bishop bishop = new Bishop(150, 10);
            bishop.HealthChangedEvent += ShowMessage;

            Console.WriteLine(warrior.Health);
            bishop.Heal(warrior);
            Console.WriteLine(warrior.Health);
            warrior.Attack(bishop);


        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
