using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.HealthChangedEvent += ShowMessage;
            Peasant peasant = new Peasant();
            peasant.HealthChangedEvent += ShowMessage;
            Console.WriteLine(peasant.Health);
            Bishop bishop = new Bishop();
            bishop.HealthChangedEvent += ShowMessage;
            Console.WriteLine(bishop.Health);

            warrior.Attack(peasant, 60);
            Console.WriteLine(peasant.Health);

        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
