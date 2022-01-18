using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            Peasant peas = new Peasant();
            peas.HealthChandgedEvent += showHealth;
            Console.WriteLine("Вы воин убейте крестьянина!(attack)");
            attackUnit(war, peas);
            attackUnit(war, peas);
            attackUnit(war, peas);
            attackUnit(war, peas);


        }

        static void attackUnit(Unit attacker, Unit defender)
        {
            defender.Health = defender.Health - attacker.Damage;
        }

        static void showHealth(double health)
        {
            Console.WriteLine("Здоровье крестьянина: " + health);
        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
