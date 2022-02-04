using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit, IMovableUnit, IBattleUnit
    {
        public Bishop(string name) : base(name, 200)
        {
            HealAmount = 100;
            WalkingSpeed = 2.3;
            damage = 13;
            CanRangeAttack = false;
            MaxRangeAttack = 1;
            AttackSpeed = 1;
        }

        public double HealAmount { get; set; }
        public double WalkingSpeed { get; set ; }
        public double damage { get ; set ; }
        public bool CanRangeAttack { get ; set ; }
        public double MaxRangeAttack { get ; set ; }
        public double AttackSpeed { get ; set ; }

        public void AttackUnit(IUnit defender, double distance)
        {
            if (distance <= MaxRangeAttack)
            {
                defender.Health -= (new Random()).Next((int)(damage * 0.8), (int)(damage * 1.2));
            }

        }

        //public Bishop(string name) : base(name, 150, 2.3, 7, 3, false , 1)
        //{
        //    HealAmount = 100;

        //}
        public void Heal(Unit pers)
        {
            if (pers.Health != 0)
            {
                if (pers.Health + HealAmount < pers.maxHealth)
                {
                    pers.Health += HealAmount;
                }
                else
                {
                    pers.Health = pers.maxHealth;
                }
            }
            else
            {
                Console.WriteLine("It is impossible to heal a dead hero");
            }
            
        }
    }
}
