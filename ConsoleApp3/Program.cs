using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(50, 30);
            warrior.HealthChangedEvent += ShowMessage;
            Peasant peasant = new Peasant();
            peasant.HealthChangedEvent += ShowMessage;
            Console.WriteLine(warrior.Health);
            peasant.Attack(warrior);

        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

        // 1. create methods for inflict damage
        // 2. health value can not be less than 0/

    }
}
