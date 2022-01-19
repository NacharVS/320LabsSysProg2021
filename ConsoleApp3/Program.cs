using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("Bob");
            Peasant peas = new Peasant("Jimmy");
            
            Bishop bish = new Bishop("Diyar");
            Console.WriteLine("Вы воин убейте крестьянина!(attack)");
            attackUnit(war, peas);
            attackUnit(war, peas);
            Console.WriteLine("О нет это хиллер он вылечил крестьянина");
            bish.Heal(peas);
            attackUnit(war, peas);
            attackUnit(war, peas);


        }

        static void attackUnit(Unit attacker, Unit defender)
        {
            defender.Health = defender.Health - attacker.Damage;
        }

        
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
