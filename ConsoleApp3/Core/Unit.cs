using ConsoleApp3.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		private double _health;
		public string Name { get; private set; }
		public virtual double MaxHealth { get; set; }
		private double _damage;
		public double WalkingSpeed;
		public double AttackSpeed;
		public bool CanRangeAttack;
		public double MaxRangeAttack;

		public delegate void HealthChangedDelegate(double health, double valueChanged, string nameUnit);
		public delegate void UnitCreatedDelegate(string nameUnit);
		public delegate void UnitDiedDelegate(string nameUnit);

		public event UnitCreatedDelegate CreateUnitEvent;
		public event HealthChangedDelegate HealthChandgedEvent;
		public event UnitDiedDelegate DieUnitEvent;

		public Unit(string name, double health, double damage, double walkingSpeed, double attackSpeed, bool canRangeAttack, double rangeAttack)
        {
			Name = name;
			_damage = damage;
			WalkingSpeed = walkingSpeed;
			AttackSpeed = attackSpeed;
			_health = health;
			MaxHealth = _health;
			CanRangeAttack = canRangeAttack;
			MaxRangeAttack = rangeAttack;

			DieUnitEvent += Termination;
			HealthChandgedEvent += showHealth;
			CreateUnitEvent += Create;
			CreateUnitEvent?.Invoke(Name);
		}
		
		public double Health
		{
			get { return _health; }
			set
			{
				if (value > 0)
				{
					HealthChandgedEvent?.Invoke(value, value - _health, Name);
					_health = value;
					
				}
				else
				{
					if(_health == 0)
                    {
						//Console.WriteLine("Cant do this, unit just died");
                    }
                    else
                    {
						_health = 0;
						HealthChandgedEvent?.Invoke(_health, value, Name);
						DieUnitEvent?.Invoke(Name);
					}
					
				}
			}
		}

		public virtual void AttackUnit(Unit defender, double distance)
        {
			if(distance <= MaxRangeAttack)
            {
				defender.Health -= (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2));
			}
			
        }
		public virtual void AttackUnit(Building defender, double distance)
		{
			defender.Health -= (new Random()).Next((int)(Damage * 0.8), (int)(Damage * 1.2));
		}
		public double Damage
        {
			get { return _damage; }
			set{_damage = value;}
		}

		public void Create(string unitName)
        {
			Console.WriteLine(unitName + " was created");
        }

		public void Termination(string unitName)
        {
			Console.WriteLine(unitName + " died");
		}

		static void showHealth(double health, double value, string name)
		{
			Console.WriteLine($"Health  {name}: {health} . Сhanged to {value}");
		}


	}
}
