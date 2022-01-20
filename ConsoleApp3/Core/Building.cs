using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Core
{
	class Building
	{
		private double _wall;
		public string Name { get; private set; }
		public virtual double MaxHealth { get; set; }
		private double _damage;

		public double AttackSpeed;
		public bool CanRangeAttack;
		public double MaxRangeAttack;

		public delegate void HealthChangedDelegate(double health, double valueChanged, string nameUnit);
		public delegate void UnitCreatedDelegate(string nameUnit);
		public delegate void UnitDiedDelegate(string nameUnit);

		public event UnitCreatedDelegate CreateBuildingEvent;
		public event HealthChangedDelegate HealthChandgedEvent;
		public event UnitDiedDelegate DieBuildingEvent;
		public Building(string name, double hp, bool rangeAttack, double damage, double attackSpeed, double maxRangeAttack)
		{
			Name = name;
			Health = hp;
			CanRangeAttack = rangeAttack;
			_damage = damage;
			AttackSpeed = attackSpeed;
			MaxRangeAttack = maxRangeAttack;

			DieBuildingEvent += Termination;
			HealthChandgedEvent += showHealth;
			CreateBuildingEvent += Create;
			CreateBuildingEvent?.Invoke(Name);

		}

		public double Health
		{
			get { return _wall; }
			set
			{
				if (value > 0)
				{
					HealthChandgedEvent?.Invoke(value, value - _wall, Name);
					_wall = value;

				}
				else
				{
					if (_wall == 0)
					{
						//Console.WriteLine("Cant do this, unit just died");
					}
					else
					{
						_wall = 0;
						HealthChandgedEvent?.Invoke(_wall, value, Name);
						DieBuildingEvent?.Invoke(Name);
					}

				}

			}
		}
		public double Damage
		{
			get { return _damage; }
			set { _damage = value; }
		}

		public virtual void AttackUnit(Unit defender, double distance)
		{
            if (CanRangeAttack)
            {
				defender.Health -= (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2));
			}
			
		}

		


		public void Create(string unitName)
		{
			Console.WriteLine(unitName + " was created");
		}

		public void Termination(string unitName)
		{
			Console.WriteLine(unitName + " destroyed");
		}

		static void showHealth(double health, double value, string name)
		{
			Console.WriteLine($"Wall health of {name}: {health} . Сhanged to {value}");
		}
	}
}
