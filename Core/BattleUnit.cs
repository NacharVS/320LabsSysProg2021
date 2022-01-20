using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class BattleUnit : MovableUnit
    {
		public bool rage = false;
		public BattleUnit(string name, double health, double walkingSpeed, double damage, double attackSpeed) : base(name, health, walkingSpeed)
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

		public virtual double MleeAttack()
		{
			double damage = (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2));
			return damage;
		}
	}
}
