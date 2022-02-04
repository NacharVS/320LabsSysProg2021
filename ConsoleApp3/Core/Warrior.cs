using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Warrior : UnitBattle, IUnitBattle
    {
        public Warrior(string name, double health, int attackSpeed, int walkingSpeed, int min, int max) : base(name, health, attackSpeed, walkingSpeed, min, max)
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
