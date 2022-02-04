using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Warrior : BattleUnit, IBattleUnit
    {
        public Warrior(string name, double health, int attackSpeed, int walkSpeed, int min, int max) : base(name, health, attackSpeed, walkSpeed, min, max)
        {
           
        }
        private double _damage;

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
    }
}
