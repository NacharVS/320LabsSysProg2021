using ConsoleApp3.Core;
using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Catapult : Unit, IMovableUnit, IBattleUnit
    {
        public int valuePatron;
        public double WalkingSpeed { get ; set; }
        public double damage { get; set; }
        public bool CanRangeAttack { get; set; }
        public double MaxRangeAttack { get; set; }
        public double AttackSpeed { get; set; }


        public Catapult(string name ) : base(name, 300)
        {
            valuePatron = 10;
            WalkingSpeed = 0.5;
            damage = 50;
            CanRangeAttack = true;
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


        //public Catapult(string name): base(name, 300, 50, 0.4, 10, true , 100)
        //{
        //    valuePatron = 10;
        //}

    }


    }
