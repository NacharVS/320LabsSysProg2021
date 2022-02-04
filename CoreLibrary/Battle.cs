﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Battle
    {
        public static void Fight(Unit leftUnit, Unit rightUnit, double distance)
        {
            leftUnit.HealthChangedEvent += ShowMessage;
            rightUnit.HealthChangedEvent += ShowMessage;

            Task LeftRightTask;
            Task RightLeftTask;

            while (leftUnit.Health > 0 && rightUnit.Health > 0)
            {
                LeftRightTask = new Task(() => UnitAttack(leftUnit, rightUnit, distance));
                RightLeftTask = new Task(() => UnitAttack(rightUnit, leftUnit, distance));

                LeftRightTask.Start();
                RightLeftTask.Start();
                LeftRightTask.Wait();
                RightLeftTask.Wait();
            }
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
