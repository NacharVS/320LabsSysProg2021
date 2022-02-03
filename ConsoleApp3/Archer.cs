using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit
    {
        private int _arrowCount = 5;
        public double AttackRange;
        public double RangeAttackSpeed;
        

        public delegate void ArrowCountChangedDelegate(string message);
        public event ArrowCountChangedDelegate ArrowCountChangedEvent;

        public int ArrowCount
        {
            get { return _arrowCount; }
            set
            {
                if (value > 0)
                {
                    _arrowCount = value;
                    ArrowCountChangedEvent?.Invoke($"{_arrowCount} arrow is left");
                }
                else
                {
                    _arrowCount = 0;
                    ArrowCountChangedEvent?.Invoke("there are no more arrow, switch to melee attack");
                }
            }

        }
        public Archer(double hitPoints, double hitDamage, string name)
        {
            Health = hitPoints;
            AttackValue = hitDamage;
            Name = name;
            //AttackSpeed = attackSpeed;
            //WalkingSpeed = walkspeed;
            //AttackRange = attackRange;
            //RangeAttackSpeed = AttackSpeed * 2;
        }

        public override void Attack(Unit u, double damage)
        {
            if (ArrowCount > 0 && damage > 0)
            {
                damage *= 1.5;
                this.Shoot(u, damage);
            }
            else
            {
                if (damage > 0)
                {
                    u.Health -= damage;
                }
            }
        }
        private void Shoot(Unit u, double damage)
        {
            u.Health -= damage;
            this.ArrowCount--;
        }
    }
}
