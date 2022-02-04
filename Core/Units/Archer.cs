using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.Units
{
    public class Archer : LongRangeUnit, IBattleUnit, IMovableUnit, IRangedUnit
    {
        public Archer(string newName)
        {
            Name = newName;
            MaxHealth = 200;
            Health = MaxHealth;
            Ammo = 20;
        }

        public double Damage => 7;
        public double AttackSpeed => 7;
        public string Name { get => _name; set => _name = value; }
        public double Health { get => _health; set => _health = value < 0 ? 0 : value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double WalkingSpeed => 2; 
        public double Ammo { get => _ammo; set => _ammo = value; }
        public double RangeDamage => 25;

        public void Attack(IUnit unit)
        {
            RangeAttack(unit);
        }

        public void MeleeAttack(IUnit unit)
        {
            unit.Health -= new Random().Next((int)(0.8 * Damage), (int)(1.2 * Damage) + 1);
        }

        public void Move()
        {
            Console.WriteLine($"{Name} speed {WalkingSpeed}");
        }

        public void RangeAttack(IUnit unit)
        {
            if (Ammo > 0)
            {
                unit.Health -= new Random().Next((int)(0.8 * RangeDamage), (int)(1.2 * RangeDamage) + 1);
                Ammo--;
            }
            else
            {
                MeleeAttack(unit);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Ammo:{Ammo};";
        }
    }
}
