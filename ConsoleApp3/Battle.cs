using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ConsoleApp3
{
    class Battle
    {
        private static Unit firstUnit;
        private static Unit secondUnit;
        private static Timer firstUnitAttackTimer;
        private static Timer secondUnitAttackTimer;

        public static void Fight(BattleUnit unit1, BattleUnit unit2)
        {
            firstUnit = unit1;
            secondUnit = unit2;

            SetTimers();

            while (unit1.Health > 0 && unit2.Health > 0)
            {
                EnableTimers();
            }
        }
        public static void Fight(Archer archer, BattleUnit unit2)
        {
            firstUnit = archer;
            secondUnit = unit2;
            SetTimers();

            while (archer.Health > 0 && unit2.Health > 0)
            {
                EnableTimers();
            }
        }

        public static void Fight(Building building, BattleUnit unit2)
        {
            firstUnit = building;
            secondUnit = unit2;
            SetTimers();

            if (unit2.IsCatapult)
            {
                while (building.Health > 0)
                {
                    EnableTimers();
                }
            }
            else
            {
                Console.WriteLine($"{unit2.Name} can not attack Building");
            }
        }
        private static void FirstUnitAttack(Object source, ElapsedEventArgs e)
        {
            if (firstUnit.GetType() == typeof(Archer))
                secondUnit.Health -= (firstUnit as Archer).RangeAttack(new Random());
            else if (firstUnit.GetType() == typeof(Soldier))
                secondUnit.Health -= (firstUnit as Soldier).MleeAttack(new Random());
            secondUnit.Info();
        }
        private static void SecondUnitAttack(Object source, ElapsedEventArgs e)
        {
            if (secondUnit.GetType() == typeof(Archer))
                firstUnit.Health -= (secondUnit as Archer).RangeAttack(new Random());
            else if (secondUnit.IsCatapult || (secondUnit.GetType() == typeof(Soldier)))
            {
                if (firstUnit.GetType() == typeof(Building))
                {
                    if ((firstUnit as Building).Wall > 0)
                    {
                        (firstUnit as Building).Wall -= (secondUnit as BattleUnit).MleeAttack(new Random());
                    }
                    else
                    {
                        firstUnit.Health -= (secondUnit as BattleUnit).MleeAttack(new Random());
                    }
                }
                else 
                {
                    firstUnit.Health -= (secondUnit as BattleUnit).MleeAttack(new Random());
                }   
            }
                
            firstUnit.Info();
        }
        private static void SetTimers()
        {
            firstUnitAttackTimer = new Timer();
            firstUnitAttackTimer.Interval = firstUnit.AttackSpeed > 0? firstUnit.AttackSpeed: 1;
            firstUnitAttackTimer.Elapsed += FirstUnitAttack;

            secondUnitAttackTimer = new Timer();
            secondUnitAttackTimer.Interval = secondUnit.AttackSpeed > 0? secondUnit.AttackSpeed: 1;
            secondUnitAttackTimer.Elapsed += SecondUnitAttack;
        }
        private static void EnableTimers()
        {
            firstUnitAttackTimer.Enabled = true;
            secondUnitAttackTimer.Enabled = true;
        }
    }    
}
