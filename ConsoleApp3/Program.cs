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
            Console.WriteLine($"Peasant has {peasant.Health}");
            //each damage takes 10 hp
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            warrior.DamageUnit(peasant);
            Console.WriteLine($"Peasant has {peasant.Health}");

        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
