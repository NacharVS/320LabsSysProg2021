using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Peasant : Unit, IMovableUnit, IBattleUnit
    {
        //public Peasant(string name) : base(name, 300, 5, 1.5, 3, false, 0)
        //{

        //}
        public double WalkingSpeed { get; set; }
        public double damage { get; set; }
        public bool CanRangeAttack { get; set; }
        public double MaxRangeAttack { get; set; }
        public double AttackSpeed { get; set; }
        public Peasant(string name) : base(name, 300)
        {
            WalkingSpeed = 1.5;
            damage = 5;
            CanRangeAttack = false;
            MaxRangeAttack = 100;
            AttackSpeed = 15;
        }

        public void AttackUnit(IUnit defender, double distance)
        {
            if (distance <= MaxRangeAttack)
            {
                defender.Health -= (new Random()).Next((int)(damage * 0.8), (int)(damage * 1.2));
            }

        }
    }
    }
