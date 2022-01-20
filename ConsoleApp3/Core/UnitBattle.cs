using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class UnitBattle : MovingUnit
    {
		public bool rage = false;

		public UnitBattle(string name, double health, double walkingSpeed, double damage, double attackSpeed) : base(name, health, walkingSpeed)
		{
			Damage = damage;
			AttackSpeed = attackSpeed;
		}

		private double _damage;

		public double Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		private double _attackSpeed;

		public double AttackSpeed
		{
			get { return _attackSpeed; }
			set { _attackSpeed = value; }
		}

		public virtual double Infighting()
		{
			double damage = (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2) + 1);
			return damage;
		}
	}
}
