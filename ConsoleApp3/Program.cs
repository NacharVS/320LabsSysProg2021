    using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var warrior = new Warrior();
            var archer = new Archer();
            var cleric = new Cleric();
            Console.WriteLine($"HP: {warrior.Health}");
            warrior.HealthChangedEvent += ShowMessage;
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);

            Heal(cleric, warrior);
        }

        public static void Attack(Character attackingCharacter, Character attackedCharacter)
        {
            attackedCharacter.Damage(attackingCharacter.Attack);
        }

        public static void Heal(Character healingCharacter, Character healedCharacter)
        {
            healedCharacter.Heal((healingCharacter as Cleric).Healing);
        }
        public static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
