using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Archer : Unit, IBattleUnit
    {
        private int _arrowCount = 5;
        //public double AttackRange;
        //public double RangeAttackSpeed;

        public double damage { get; set; }
        public double health { get { return Health; } set { Health = value; } }
        public string name { get; set; }


        public delegate void ArrowCountChangedDelegate(string message);
        public event ArrowCountChangedDelegate ArrowCountChangedEvent;

        public Archer(double hitPoints, double hitDamage, string name)
        {
            Health = hitPoints;
            damage = hitDamage;
            this.name = name;
            Name = name;
            //AttackSpeed = attackSpeed;
            //WalkingSpeed = walkspeed;
            //AttackRange = attackRange;
            //RangeAttackSpeed = AttackSpeed * 2;
        }
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

        public void Attack(IBattleUnit u, double damage)
        {
            if (ArrowCount > 0 && damage > 0)
            {
                this.Shoot(u, damage * 1.5);
            }
            else
            {
                if (damage > 0)
                {
                    u.health -= damage;
                }
            }
        }
        private void Shoot(IBattleUnit u, double damage)
        {
            u.health -= damage;
            this.ArrowCount--;
        }
    }
}
