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

            Console.WriteLine(warrior.Health);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
