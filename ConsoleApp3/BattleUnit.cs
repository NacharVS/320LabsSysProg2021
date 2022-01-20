using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class BattleUnit : Unit
    {
        private double attackSpeed;
        private double walkingSpeed;

        public BattleUnit(string name, double health, double damage, double attackSpeed, double walkingSpeed):base(name,health,damage)
        {
            this.attackSpeed = attackSpeed;
            this.walkingSpeed = walkingSpeed;
        }

        public virtual double MeleeAttack()
        {
            return 5;
        }
    }
}
