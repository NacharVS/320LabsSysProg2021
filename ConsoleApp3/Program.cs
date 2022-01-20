using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier("Petya");
            var archer = new Archer("Li");
            var cleric = new Cleric("Abdul");

            Battle(archer, soldier, 1);
        }

        public static void Battle(Unit leftUnit, Unit rightUnit, double distance)
        {
            leftUnit.HealthChangedEvent += ShowMessage;
            rightUnit.HealthChangedEvent += ShowMessage;

            Thread rightUnitThread;

            while (leftUnit.Health > 0 && rightUnit.Health > 0)
            {
                UnitAttackParameters unitAttackParameters = new UnitAttackParameters(rightUnit, leftUnit, distance);
                rightUnitThread = new Thread(new ParameterizedThreadStart(UnitAttack));
                rightUnitThread.Start(unitAttackParameters);
                UnitAttack(leftUnit, rightUnit, distance);
            }
        }
        public static void UnitAttack(object obj)
        {
            UnitAttackParameters unitAttackParameters = (UnitAttackParameters)obj;
            UnitAttack(unitAttackParameters.AttackingUnit, unitAttackParameters.AttackedUnit, unitAttackParameters.Distance);
        }
        public static void UnitAttack(Unit attackingUnit, Unit attackedUnit, double distance)
        {
            if (attackingUnit is RangeUnit && (attackingUnit as RangeUnit).RangeProjectileCount > 0)
                RangeUnitAttack(attackingUnit as RangeUnit, attackedUnit, distance);
            else
                MleeUnitAttack(attackingUnit, attackedUnit, distance);
        }
        public static void MleeUnitAttack(Unit attackingUnit, Unit attackedUnit, double distance)
        {
            attackingUnit.MleeAttack(attackingUnit, attackedUnit, distance);
        }
        public static void RangeUnitAttack(RangeUnit attackingUnit, Unit attackedUnit, double distance)
        {
            if (attackingUnit.RangeProjectileCount > 0)
                attackingUnit.RangeAttack(attackingUnit, attackedUnit, distance);
            else
                attackingUnit.MleeAttack(attackingUnit, attackedUnit, distance);
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
