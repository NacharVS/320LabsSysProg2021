using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace ConsoleApp3
{
    class Battle
    {
        public delegate void DistanceChangeDelegate(string distance);
        public event DistanceChangeDelegate DistanceChangeEvent;
        
        private double _distanceBetween;
        public double DistanceBetween
        {
            get { return _distanceBetween; }
            set
            {
                if (value > 0)
                {
                    _distanceBetween = value;
                }
                else
                {
                    _distanceBetween = 0;
                }
                DistanceChangeEvent?.Invoke($"Current distance is {_distanceBetween}");
            }
        }

        private Unit _firstUnit;
        private Unit _secondUnit;

        public Battle(Unit firstUnit, Unit secondUnit, double distanceBetween)
        {
            DistanceBetween = distanceBetween;
            _firstUnit = firstUnit;
            _secondUnit = secondUnit;
        }

        public void Fight()
        {
            System.Timers.Timer secondUnitAttackTimer = new System.Timers.Timer();
            secondUnitAttackTimer.Elapsed += new ElapsedEventHandler(SecondUnitAttack);
            secondUnitAttackTimer.Interval = _secondUnit.AttackSpeed;

            System.Timers.Timer firstUnitAttackTimer = new System.Timers.Timer();
            firstUnitAttackTimer.Elapsed += new ElapsedEventHandler(FirstUnitAttack);
            firstUnitAttackTimer.Interval = _firstUnit.AttackSpeed;
            while (_firstUnit.Health > 0 && _secondUnit.Health > 0)
            {
                if (CheckDistance(_secondUnit))
                {
                    secondUnitAttackTimer.Enabled = true;
                }
                if (CheckDistance(_firstUnit))
                {
                    firstUnitAttackTimer.Enabled = true;
                }
                Thread.Sleep(500);
            }
        }

        private bool CheckDistance(Unit unit)
        {
            if (unit.MaxRangeAttack <= _distanceBetween)
            {
                DistanceBetween -= unit.WalkingSpeed;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Attack(double damage, Unit attackedUnit)
        {
            attackedUnit.Health -= damage;
        }

        void SecondUnitAttack(Object source, ElapsedEventArgs e)
        {
            Attack(_secondUnit.Damage, _firstUnit);
        }
        void FirstUnitAttack(Object source, ElapsedEventArgs e)
        {
            Attack(_firstUnit.Damage, _secondUnit);
        }
    }
}
