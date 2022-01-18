using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Peasant peasant = new Peasant();
            peasant.UnitHealthEvent += Show;
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
        }

        public static  void Attack(int damage, Unit attackedUnit)
        {
            attackedUnit.Health -= damage;
        }

        public static  void Show(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
