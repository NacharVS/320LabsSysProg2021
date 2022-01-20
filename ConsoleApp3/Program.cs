using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier("Petya");
            var archer = new Archer("Li");
            var cleric = new Cleric("Abdul");

            Battle(archer, soldier, 10);
        }

        public static void Battle(Unit leftUnit, Unit rightUnit, double distance)
        {
            leftUnit.HealthChangedEvent += ShowMessage;
            rightUnit.HealthChangedEvent += ShowMessage;

            if (leftUnit is RangeUnit)
                Console.WriteLine("OK");
            Console.WriteLine(leftUnit.GetType());

            while (leftUnit.Health > 0 && rightUnit.Health > 0)
            {
                if (leftUnit is RangeUnit && (leftUnit as RangeUnit).RangeProjectileCount > 0)
                {
                    RangeUnitAttack(leftUnit as RangeUnit, rightUnit, distance);
                }
            }
        }

        public static void MleeUnitAttack(Unit attackingCharacter, Unit attackedCharacter, double distance)
        {
            attackingCharacter.MleeAttack(attackingCharacter, attackedCharacter, distance);
        }
        public static void RangeUnitAttack(RangeUnit attackingCharacter, Unit attackedCharacter, double distance)
        {
            if (attackingCharacter.RangeProjectileCount > 0)
                attackingCharacter.RangeAttack(attackingCharacter, attackedCharacter, distance);
            else
                attackingCharacter.MleeAttack(attackingCharacter, attackedCharacter, distance);
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
