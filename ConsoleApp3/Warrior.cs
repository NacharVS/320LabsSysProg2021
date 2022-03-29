using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit, IBattleUnit
    {
        public double damage{get; set;}
        public double health{ get { return Health; } set { Health = value;} }
        public string name { get; set;}
        public Warrior(double hitPoints, double hitDamage, string name)
        {  
            Health = hitPoints;
            damage = hitDamage;
            this.name = name;
            Name = name;
            //this.AttackSpeed = attackSpeed;
            //this.WalkingSpeed = walkingSpeed;
        }

        public virtual void Attack(IBattleUnit u, double damage)
        {
            if (damage > 0 && u.health > 0)
            {
                u.health -= damage;
            }
        }
    }
}
