using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier("Petya");
            var archer = new Archer("li");
            var cleric = new Cleric("Abdul");


        }

        public void Battle(Unit leftUnit, Unit rightUnit, int distance)
        {
            leftUnit.HealthChangedEvent += ShowMessage;
            rightUnit.HealthChangedEvent += ShowMessage;

            while (leftUnit.Health > 0 && rightUnit.Health > 0)
            {

            }
        }

        public static void MleeAttack(Unit attackingCharacter, Unit attackedCharacter)
        {
            attackedCharacter.Damage(attackingCharacter.MleeDamage);
            attackingCharacter.MleeAttack();
        }
        public static void RangeAttack(RangeUnit attackingCharacter, Unit attackedCharacter)
        {
            attackedCharacter.Damage(attackingCharacter.RangeDamage);
            attackingCharacter.RangeAttack();
        }

        public static void Heal(Unit healingCharacter, Unit healedCharacter)
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
