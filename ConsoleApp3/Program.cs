using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.InflictDamageEvent += ShowHealth;

            Peasant peasant = new Peasant();
            peasant.Health = 100;

            warrior.InflictDamageToPeasant(peasant, 1000);
        }
        private static void ShowHealth(Peasant peasant, int damage)
        {
            Console.WriteLine(peasant.Health);
        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
