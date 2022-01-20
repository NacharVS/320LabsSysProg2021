using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("Bob");
            Warrior war2 = new Warrior("Kirill");
            Peasant peas = new Peasant("Jimmy");
            Archer arch = new Archer("Salavat");
            Bishop bish = new Bishop("Diyar");
            Console.WriteLine("Вы воин убейте крестьянина!(attack)");
            //war.AttackUnit(peas);
            Battle bat = new Battle(war, arch, 60);


        }

        static void attackUnit(Unit attacker, Unit defender)
        {
            defender.Health -= attacker.Damage;
        }

        
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
