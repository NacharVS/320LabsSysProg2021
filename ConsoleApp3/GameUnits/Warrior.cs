using System;

namespace ConsoleApp3
{
    class Warrior : WalkingUnits
    {
        public override double MaxHealth => 1000;
        public Warrior(string name) : base(name)
        {
            Health = 1000;
            Damage = 1;
            Speed = 10;
            AttackSpeed = 0.5;
            AttackRange = 5;
        }

        public override double GetDamage()
        {
            return Damage;
        }
    }
}
