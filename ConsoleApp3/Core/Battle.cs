using ConsoleApp3.Core;
using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading;
using System.Timers;

namespace ConsoleApp3
{
    class Battle
    {
        public double DistanceBetweenUnits;
        public Battle(Unit firstUnit, Unit secondUnit, double distance)
        {
            Console.WriteLine($"The battle between {firstUnit.Name} and {secondUnit.Name} has begun. Distance: {distance}");
            DistanceBetweenUnits = distance;

            System.Timers.Timer distanceMoveTimer = new System.Timers.Timer();
            distanceMoveTimer.Elapsed += new ElapsedEventHandler(moveUnits);
            distanceMoveTimer.Interval = 1000;

            System.Timers.Timer secondUnitAttackTimer = new System.Timers.Timer();
            secondUnitAttackTimer.Elapsed += new ElapsedEventHandler(SecondUnitAttack);
            secondUnitAttackTimer.Interval = secondUnit.AttackSpeed * 1000;

            System.Timers.Timer firstUnitAttackTimer = new System.Timers.Timer();
            firstUnitAttackTimer.Elapsed += new ElapsedEventHandler(FirstUnitAttack);
            firstUnitAttackTimer.Interval = firstUnit.AttackSpeed * 1000;

            if (firstUnit.CanRangeAttack)
            {
                firstUnitAttackTimer.Enabled = true;
            }

            if (secondUnit.CanRangeAttack)
            {
                secondUnitAttackTimer.Enabled = true;
            }

            while (firstUnit.Health != 0 && secondUnit.Health != 0)
            {
                if (DistanceBetweenUnits > 1)
                {
                    distanceMoveTimer.Enabled = true;

                }
                else
                {
                    distanceMoveTimer.Enabled = false;
                    firstUnitAttackTimer.Enabled = true;
                    secondUnitAttackTimer.Enabled = true;
                }
            }
            firstUnitAttackTimer.Enabled = false;
            secondUnitAttackTimer.Enabled = false;

            void SecondUnitAttack(Object source, System.Timers.ElapsedEventArgs e)
            {
                secondUnit.AttackUnit(firstUnit, DistanceBetweenUnits);
            }
            void FirstUnitAttack(Object source, System.Timers.ElapsedEventArgs e)
            {
                firstUnit.AttackUnit(secondUnit, DistanceBetweenUnits);
            }
            void moveUnits(Object source, System.Timers.ElapsedEventArgs e)
            {
                if (!firstUnit.CanRangeAttack || DistanceBetweenUnits > firstUnit.MaxRangeAttack)
                {
                    DistanceBetweenUnits -= firstUnit.WalkingSpeed;
                }
                else
                {

                }

                if (!secondUnit.CanRangeAttack || DistanceBetweenUnits > secondUnit.MaxRangeAttack)
                {
                    DistanceBetweenUnits -= secondUnit.WalkingSpeed;
                }
                else
                {

                }
                Console.WriteLine($"Distance change to {DistanceBetweenUnits}");

            }
        }


        public Battle(Unit firstUnit, Building secondUnit, double distance)
        {


        }

    }
}
