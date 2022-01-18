using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Peasant peasant = new Peasant();
            Bishop bishop = new Bishop();
            peasant.HealthChangeEvent += Show;
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Health(bishop.Heal(), peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
            Attack(warrior.Attack, peasant);
        }

        public static void Health(double health, Unit healedUnit)
        {
            healedUnit.Health += health;
        }

        public static void Attack(double damage, Unit attackedUnit)
        {
            attackedUnit.Health -= damage;
        }

        public static void Show(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
