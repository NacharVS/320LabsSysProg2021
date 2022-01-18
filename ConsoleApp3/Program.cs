using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(50);
            Peasant peasant = new Peasant(100);
            
            warrior.HealthChangedEvent += ShowMessage;
            peasant.HealthChangedEvent += ShowMessage;

            Console.WriteLine(peasant.Health);
            warrior.Attack(peasant, 110);
            Console.WriteLine(peasant.Health);
        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
