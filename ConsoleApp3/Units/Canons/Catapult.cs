using System;

namespace ConsoleApp3
{
    class Catapult : RangeUnit, IBattleUnit, IMovingUnit, IRangeUnit
    {
        public Catapult(string newName)
        {
            Name = newName;
            MaxHealth = 200;
            Health = MaxHealth;
            Ammo = 20;
        }

        public double Damage => 0;
        public double AttackSpeed => 20;
        public string Name { get => _name; set => _name = value; }
        public double Health { get => _health; set => _health = value < 0 ? 0 : value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double WalkingSpeed => 0.5;
        public double Ammo { get => _ammo; set => _ammo = value; }
        public double RangeDamage => 60;

        public void Attack(IUnit unit)
        {
            RangeAttack(unit);
        }

        public void Move()
        {
            Console.WriteLine($"{Name} speed {WalkingSpeed}"); ;
        }

        public void RangeAttack(IUnit unit)
        {
            if (Ammo > 0)
            {
                unit.Health -= new Random().Next((int)(RangeDamage / 2), (int)RangeDamage);
                Ammo--;
            }
            else
            {
                Console.WriteLine("No ammo");
            }
        }

    }
}
