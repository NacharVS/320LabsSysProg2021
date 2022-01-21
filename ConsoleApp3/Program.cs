﻿using System;
using System.Threading;
using System.Threading.Tasks;

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

            while (leftUnit.Health > 0 && rightUnit.Health > 0)
            {
                UnitAttackAsync(leftUnit, rightUnit, distance);
                UnitAttackAsync(rightUnit, leftUnit, distance);
            }
        }
        public static async void UnitAttackAsync(Unit attackingUnit, Unit attackedUnit, double distance)
        {
            await Task.Run(() => UnitAttack(attackingUnit, attackedUnit, distance));
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
            Thread.Sleep(attackingUnit.MleeAttackSpeed);
        }
        public static void RangeUnitAttack(RangeUnit attackingUnit, Unit attackedUnit, double distance)
        {
            if (attackingUnit.RangeProjectileCount > 0)
            {
                attackingUnit.RangeAttack(attackingUnit, attackedUnit, distance);
                Thread.Sleep(attackingUnit.RangeAttackSpeed);
            }
            else
            {
                attackingUnit.MleeAttack(attackingUnit, attackedUnit, distance);
                Thread.Sleep(attackingUnit.MleeAttackSpeed);
            }
        }

        public static void Heal(Unit healingCharacter, Unit healedCharacter)
        {
            healedCharacter.Heal((healingCharacter as Cleric).Healing);
        }

        public static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
