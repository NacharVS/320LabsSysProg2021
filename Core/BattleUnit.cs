using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class BattleUnit : MovingUnits
    {
        private double attackSpeed;
        public double AttackSpeed
        {
            get { return attackSpeed; }
            set { attackSpeed = value; }
        }

        private double _damage;
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public BattleUnit(string name, double health, double walkingSpeed, double damage, double attackSpeed):base(name,health,walkingSpeed)
        {
            Damage = damage;
            this.attackSpeed = attackSpeed;
        }

        public virtual double MeleeAttack(Random random)
        {
            return 2;
            //double presentDamage = random.Next()
        }

        public void Attack(BattleUnit unit)
        {
            unit.Health -= Damage;
        }

        public override void Message()
        {
            Console.WriteLine($"Name: {Name}, health: {Health}, damage: {Damage}, attack speed: {attackSpeed}");
        }
    }
}
