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
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
            Attack(archer, warrior);
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
            if (attackingCharacter.Health <= 0)
                Console.WriteLine("Вы мертвы, действие невозможно.");
            else if (attackedCharacter.Health <= 0)
                Console.WriteLine("Враг уже мертв!");
            else
                attackedCharacter.Damage(attackingCharacter.Attack);
        }

        public static void Heal(Character healingCharacter, Character healedCharacter)
        {
            if (healingCharacter.Health <= 0)
                Console.WriteLine("Вы мертвы, действие невозможно.");
            else if (healedCharacter.Health <= 0)
                Console.WriteLine("Тело мертво... Может помочь черная магия.");
            else
                healedCharacter.Heal((healingCharacter as Cleric).Healing);
        }
        public static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
