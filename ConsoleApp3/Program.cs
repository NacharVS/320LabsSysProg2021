    using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior();
            Character archer = new Archer();
            Console.WriteLine(warrior.Health);
            warrior.HealthChangedEvent += ShowMessage;
            Attack(archer.Attack, warrior);
        }

        public static void Attack(double damage, Character attackedCharacter)
        {
            attackedCharacter.Damage(damage);
        }
        public static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
