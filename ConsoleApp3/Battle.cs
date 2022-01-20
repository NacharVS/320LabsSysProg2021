using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ConsoleApp3
{
    class Battle
    {
        private static Unit _firstUnit;
        private static Unit _secondUnit;
        private static Timer _firstUnitAttackTimer;
        private static Timer _secondUnitAttackTimer;

        public static void Fight(BattleUnit unit1, BattleUnit unit2)
        {
            _firstUnit = unit1;
            _secondUnit = unit2;

            SetTimers();

            while (unit1.Health > 0 && unit2.Health > 0)
            {
                EnableTimers();
            }
        }
        public static void Fight(Archer archer, BattleUnit unit2)
        {
            _firstUnit = archer;
            _secondUnit = unit2;
            SetTimers();

            while (archer.Health > 0 && unit2.Health > 0)
            {
                EnableTimers();
            }
        }

        public static void Fight(Building building, BattleUnit unit2)
        {
            _firstUnit = building;
            _secondUnit = unit2;
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
            if (_firstUnit.GetType() == typeof(Archer))
                _secondUnit.Health -= (_firstUnit as Archer).RangeAttack(new Random());
            else if (_firstUnit.GetType() == typeof(Soldier))
                _secondUnit.Health -= (_firstUnit as Soldier).MleeAttack(new Random());
            _secondUnit.Info();
        }
        private static void SecondUnitAttack(Object source, ElapsedEventArgs e)
        {
            if (_secondUnit.GetType() == typeof(Archer))
                _firstUnit.Health -= (_secondUnit as Archer).RangeAttack(new Random());
            else if (_secondUnit.IsCatapult || (_secondUnit.GetType() == typeof(Soldier)))
            {
                if (_firstUnit.GetType() == typeof(Building))
                {
                    if ((_firstUnit as Building).Wall > 0)
                    {
                        (_firstUnit as Building).Wall -= (_secondUnit as BattleUnit).MleeAttack(new Random());
                    }
                    else
                    {
                        _firstUnit.Health -= (_secondUnit as BattleUnit).MleeAttack(new Random());
                    }
                }
                else 
                {
                    _firstUnit.Health -= (_secondUnit as BattleUnit).MleeAttack(new Random());
                }   
            }
                
            _firstUnit.Info();
        }
        private static void SetTimers()
        {
            _firstUnitAttackTimer = new Timer();
            _firstUnitAttackTimer.Interval = _firstUnit.AttackSpeed > 0? _firstUnit.AttackSpeed: 1;
            _firstUnitAttackTimer.Elapsed += FirstUnitAttack;

            _secondUnitAttackTimer = new Timer();
            _secondUnitAttackTimer.Interval = _secondUnit.AttackSpeed > 0? _secondUnit.AttackSpeed: 1;
            _secondUnitAttackTimer.Elapsed += SecondUnitAttack;
        }
        private static void EnableTimers()
        {
            _firstUnitAttackTimer.Enabled = true;
            _secondUnitAttackTimer.Enabled = true;
        }
    }    
}
