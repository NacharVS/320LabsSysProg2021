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
            CreateUnitEvent += Create;
            CreateUnitEvent?.Invoke(Name);
        }

        public double _walkingSpeed;
        public double WalkingSpeed
        {
            get { return _walkingSpeed; }
            set { _walkingSpeed = value; }
        }
        public double _attackSpeed;
        public double AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }
        public bool _canRangeAttack;
        public bool CanRangeAttack
        {
            get { return _canRangeAttack; }
            set { _canRangeAttack = value; }
        }
        public double _maxRangeAttack;
        public double MaxRangeAttack
        {
            get { return _maxRangeAttack; }
            set { _maxRangeAttack = value; }
        }

        public string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _maxHealth;
        public double MaxHealth
        {
            get { return _maxHealth; }
            private set { _maxHealth = value; }
        }

        private double _damage;
        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
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

       
        public void Create(string unitName)
        {
            Console.WriteLine(unitName + " is created");
        }

        public void Termination(string unitName)
        {
            Console.WriteLine(unitName + " died");
        }

        public virtual void Hit(Unit unit, double distance)
        {
            if (distance <= MaxRangeAttack)
            {
                unit.Health -= this.Damage;

                if (unit.Health < 0)
                    unit.Health = 0;

                HealthChandgedEvent?.Invoke("Before health : " + (unit.Health + this.Damage)
                    + "\n" + "Damage: -" + this.Damage + "\n" + "Health: " + unit.Health);
            }
            else
            { 
            
            }
        }
    }
}
