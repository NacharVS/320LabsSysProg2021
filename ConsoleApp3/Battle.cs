using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle : Unit
    {
        private double _attackSpeed;
        private double _walkingSpeed;

        public Battle(string name, double health, double damage, double _attackSpeed, double _walkingSpeed) : base(name, health, damage)
        {
            this._attackSpeed = _attackSpeed;
            this._walkingSpeed = _walkingSpeed;
        }

        public virtual double Infighting()
        {
            return 3;
        }
        public void Attack(Battle unit)
        {
            unit.Health -= Damage;
        }
    }
}
