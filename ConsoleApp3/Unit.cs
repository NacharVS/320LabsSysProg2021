using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void UnitCreatedDelegate(string message);
        public delegate void UnitDiedDelegate(string nameUnit);
        public delegate void HealthChangedDelegate(string nameUnit);

        public event HealthChangedDelegate HealthChandgedEvent;
        public event UnitCreatedDelegate CreateUnitEvent;
        public event UnitDiedDelegate DieUnitEvent;

        public Unit(string name, double health, double damage, double attackSpeed, double walkingSpeed)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Damage = damage;
            this.attackSpeed = attackSpeed;
            this.walkingSpeed = walkingSpeed;

            DieUnitEvent += Termination;
            //HealthChandgedEvent += ShowHealth;
            //CreateUnitEvent += Create;
            CreateUnitEvent?.Invoke(Name);
        }

        private double attackSpeed;
        private double walkingSpeed;

        public string _name { get; private set; }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _maxHealth { get; set; }
        public double MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

        private double _health;
        public double Health
        {
            get { return _health; }
            set
            {
                if (value > 0)
                {
                    _health = value;
                }
                else
                {
                    if (_health == 0)
                    {
                        DieUnitEvent?.Invoke(Name + " is died");
                    }
                    else
                    {
                        _health = 0;
                        DieUnitEvent?.Invoke(Name + " is died");
                    }

                }
            }
        }

        private double _damage;
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public void Create()
        {
            Console.WriteLine($"{Name} is created");
        }

        public void Termination(string unitName)
        {
            Console.WriteLine(unitName + " died");
        }

        static void ShowHealth(double health, string name)
        {
            Console.WriteLine($"Health  {name}: {health}");
        }

        public void Hit(Unit unit)
        {
            unit.Health -= this.Damage;
            if (unit.Health < 0)
                unit.Health = 0;
            HealthChandgedEvent?.Invoke("Before health : " + (unit.Health + this.Damage) + "\n"  + "Damage: -" + this.Damage + "\n" + "Health: " + unit.Health);

        }
    }
}
