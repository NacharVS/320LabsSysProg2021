using System;
using System.Diagnostics;
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
            set {
                if(value > 0)
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

        private WalkingUnits _firstUnit;
        private WalkingUnits _secondUnit;

        public Battle(WalkingUnits firstUnit, WalkingUnits secondUnit, double distanceBetween)
        {
            DistanceBetween = distanceBetween;
            _firstUnit = firstUnit;
            _secondUnit = secondUnit;
        }

        public void Fight()
        {
            System.Timers.Timer secondUnitAttackTimer = new System.Timers.Timer();
            secondUnitAttackTimer.Elapsed += new ElapsedEventHandler(SecondUnitAttack);
            secondUnitAttackTimer.Interval = _secondUnit.AttackSpeed * 2500;

            System.Timers.Timer firstUnitAttackTimer = new System.Timers.Timer(); 
            firstUnitAttackTimer.Elapsed += new ElapsedEventHandler(FirstUnitAttack);
            firstUnitAttackTimer.Interval = _firstUnit.AttackSpeed * 2500; // магическое число возникшее во время отладки
            while (_firstUnit.Health > 0 && _secondUnit.Health > 0)
            {

                if (CheckDistance(_secondUnit))
                {
                    secondUnitAttackTimer.Enabled = true;
                }
                if(CheckDistance(_firstUnit))
                {
                    firstUnitAttackTimer.Enabled = true;
                }
                Thread.Sleep(500);
            }
        }

        private bool CheckDistance(WalkingUnits unit)
        {
            if (unit.AttackRange <= _distanceBetween)
            {
                DistanceBetween -= unit.Speed;
                return false;
            }
            else
            {
                 return true;
            }
        }

        private void Attack(double damage,Unit attackedUnit)
        {
            attackedUnit.Health -= damage; 
        }

        void SecondUnitAttack(Object source, ElapsedEventArgs e)
        {
            Attack(_secondUnit.GetDamage(), _firstUnit);
        }
        void FirstUnitAttack(Object source, ElapsedEventArgs e)
        {
            Attack(_firstUnit.GetDamage(), _secondUnit);
        }
    }
}
