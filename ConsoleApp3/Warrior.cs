using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : BattleUnit
    {
        public Warrior(string name, double health, int attackPoint, double maxHealth, int min, int max) : base(name, health,  attackPoint, maxHealth, min, max )
        {
            DamagePoint = attackPoint;
        }
        private double _damage;

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
    }
}
