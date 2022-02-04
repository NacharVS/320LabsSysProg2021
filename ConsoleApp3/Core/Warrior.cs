using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Warrior : Unit, IMovableUnit, IBattleUnit
    {
        private bool _rage = false;
        public double WalkingSpeed { get; set; }
        public double damage { get; set; }
        public bool CanRangeAttack { get; set; }
        public double MaxRangeAttack { get; set; }
        public double AttackSpeed { get; set; }
        public Warrior(string name) : base(name, 200)
        {
            WalkingSpeed = 1.5;
            damage = 5;
            CanRangeAttack = false;
            MaxRangeAttack = 100;
            AttackSpeed = 3;
        }

        //public Warrior(string name) : base(name, 200, 15, 1, 4 , false , 1)
        //{

        //}
        public void AttackUnit(IUnit defender, double distance)
        {
            if(Health > maxHealth / 2)
            {
                defender.Health -= (new Random()).Next((int)(damage * 0.8), (int)(damage * 1.2));
            }
            else
            {
                if (!_rage)
                {
                    Console.WriteLine($"{Name} activate RAGE");
                    AttackSpeed /= 2;
                }
                _rage = true;
                defender.Health -= (new Random()).Next((int)(damage * 2 * 0.8), (int)(damage * 2 * 1.2));
            }
            
        }

    }
}
