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

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
        static void ShowMessage1(string mes)
        {
            Console.WriteLine(mes+mes);
        }


        // 1. create methods for inflict damage
        // 2. health value can not be less than 0
    }
}
