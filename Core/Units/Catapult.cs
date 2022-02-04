using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;


namespace Core.Units
{
    public class Catapult : LongRangeUnit, IBattleUnit, IMovableUnit, IRangedUnit
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

        public void MeleeAttack(IUnit unit)
        {
            //No melee attack
        }

        public void Move()
        {
            Console.WriteLine($"{Name} speed {WalkingSpeed}"); ;
        }

        public void RangeAttack(IUnit unit)
        {
            if (Ammo > 0)
            {
                unit.Health -= new Random().Next((int)(0.5 * RangeDamage), (int)(1.5 * RangeDamage) + 1);
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
