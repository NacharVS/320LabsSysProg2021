using ConsoleApp3.Core;
using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading;
using System.Timers;
using ConsoleApp3.Interfaces;
using System.Reflection;

namespace ConsoleApp3
{
    class Battle
    {
        public double DistanceBetweenUnits;

        //public Battle(Unit firstUnit, IBattleUnit secondUnit, double distance)
        //{

        //}
        public Battle(IBattleUnit firstUnit, IBattleUnit secondUnit, double distance)
        {
            Console.WriteLine($"The battle has begun. Distance: {distance}");
            DistanceBetweenUnits = distance;

            //System.Timers.Timer distanceMoveTimer = new System.Timers.Timer();
            //distanceMoveTimer.Elapsed += new ElapsedEventHandler(moveUnits);
            //distanceMoveTimer.Interval = 1000;

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
               // if (DistanceBetweenUnits > 1)
                //{
                    //distanceMoveTimer.Enabled = true;
                   // if (DistanceBetweenUnits < firstUnit.MaxRangeAttack)
                   // {
                   //     firstUnitAttackTimer.Enabled = true;
                   // }
                   // if (DistanceBetweenUnits > secondUnit.MaxRangeAttack)
                   // {
                   //     secondUnitAttackTimer.Enabled = true;
                   // }
                //}
                //else
                //{
                    //distanceMoveTimer.Enabled = false;
                    firstUnitAttackTimer.Enabled = true;
                    secondUnitAttackTimer.Enabled = true;
                //}
            }
            //firstUnitAttackTimer.Enabled = false;
            //secondUnitAttackTimer.Enabled = false;

            void SecondUnitAttack(Object source, System.Timers.ElapsedEventArgs e)
            {
                secondUnit.AttackUnit(firstUnit, DistanceBetweenUnits);
            }
            void FirstUnitAttack(Object source, System.Timers.ElapsedEventArgs e)
            {
                firstUnit.AttackUnit(secondUnit, DistanceBetweenUnits);
            }
            //void moveUnits(Object source, System.Timers.ElapsedEventArgs e)
            //{
            //    if (!firstUnit.CanRangeAttack || DistanceBetweenUnits > firstUnit.MaxRangeAttack)
            //    {
            //        DistanceBetweenUnits -= firstUnit.WalkingSpeed;
            //    }

            //    if (!secondUnit.CanRangeAttack || DistanceBetweenUnits > secondUnit.MaxRangeAttack)
            //    {
            //        DistanceBetweenUnits -= secondUnit.WalkingSpeed;
            //    }

            //    Console.WriteLine($"Distance change to {DistanceBetweenUnits}");

            //}
        }


        //public Battle(IBattleUnit firstUnit, Building secondBulding, double distance)
        //{
        //    if (firstUnit.GetType() == typeof(Catapult))
        //    {
        //        Console.WriteLine($"The battle between {firstUnit.Name} and {secondBulding.Name} has begun. Distance: {distance}");
        //        DistanceBetweenUnits = distance;
        //        System.Timers.Timer distanceMoveTimer = new System.Timers.Timer();
        //        distanceMoveTimer.Elapsed += new ElapsedEventHandler(moveUnits);
        //        distanceMoveTimer.Interval = 1000;

        //        System.Timers.Timer secondBuildingAttackTimer = new System.Timers.Timer();
        //        secondBuildingAttackTimer.Elapsed += new ElapsedEventHandler(SecondBuildingAttack);
        //        if (secondBulding.AttackSpeed != 0)
        //        {

        //            secondBuildingAttackTimer.Interval = secondBulding.AttackSpeed * 1000;
        //        }


        //        System.Timers.Timer firstUnitAttackTimer = new System.Timers.Timer();
        //        firstUnitAttackTimer.Elapsed += new ElapsedEventHandler(FirstUnitAttack);
        //        firstUnitAttackTimer.Interval = firstUnit.AttackSpeed * 1000;

        //        if (firstUnit.CanRangeAttack)
        //        {
        //            firstUnitAttackTimer.Enabled = true;
        //        }

        //        if (secondBulding.CanRangeAttack)
        //        {
        //            secondBuildingAttackTimer.Enabled = true;
        //        }

        //        while (firstUnit.Health != 0 && secondBulding.Health != 0)
        //        {
        //            if (DistanceBetweenUnits > 1)
        //            {
        //                distanceMoveTimer.Enabled = true;
        //                if (DistanceBetweenUnits < firstUnit.MaxRangeAttack)
        //                {
        //                    firstUnitAttackTimer.Enabled = true;
        //                }
        //                if (DistanceBetweenUnits > secondBulding.MaxRangeAttack)
        //                {
        //                    secondBuildingAttackTimer.Enabled = true;
        //                }
        //            }
        //            else
        //            {
        //                distanceMoveTimer.Enabled = false;
        //                firstUnitAttackTimer.Enabled = true;
        //                secondBuildingAttackTimer.Enabled = true;
        //            }
        //        }
        //        firstUnitAttackTimer.Enabled = false;
        //        secondBuildingAttackTimer.Enabled = false;

        //        void SecondBuildingAttack(Object source, System.Timers.ElapsedEventArgs e)
        //        {
        //            secondBulding.AttackUnit(firstUnit, DistanceBetweenUnits);
        //        }
        //        void FirstUnitAttack(Object source, System.Timers.ElapsedEventArgs e)
        //        {
        //            if (DistanceBetweenUnits < firstUnit.MaxRangeAttack)
        //            {
        //                firstUnit.AttackUnit(secondBulding, DistanceBetweenUnits);
        //            }

        //        }
        //        void moveUnits(Object source, System.Timers.ElapsedEventArgs e)
        //        {
        //            if (!firstUnit.CanRangeAttack || DistanceBetweenUnits > firstUnit.MaxRangeAttack)
        //            {
        //                DistanceBetweenUnits -= firstUnit.WalkingSpeed;
        //                Console.WriteLine($"Distance change to {DistanceBetweenUnits}");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Only catapult can attack buldings");
        //    }
        //}

    }
}
