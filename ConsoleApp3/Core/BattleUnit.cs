using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class BattleUnit : MovableUnit
    {
        public BattleUnit(string name, double health, double moveSpeed, double damage, double attackSpeed) : base(name, health, moveSpeed)
        {
            Damage = damage;
            AttackSpeed = attackSpeed;
        }

        public virtual bool isCatapult { get => false; }
        public bool rage = false;

        private double _damage;
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        private double _attackSpeed;
        public double AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }

        private double _attackRange;
        public double AttackRange
        {
            get { return _attackRange; }
            set { _attackRange = value; }
        }

        //public void Hit(Unit unit)
        //{
        //    if (unit.Health - Damage < 0)
        //        unit.Health = 0;
        //    else
        //        unit.Health += -Damage;
        //}

        public virtual double MeleeAttack()
        {
            double damage = (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2) + 1);
            return damage;
        }
    }
}
