﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void HealthChangedDelegate(string message);

        private double _health;
        public double Health
        {
            get { return _health; }
            set
            {
                if (value > 0)
                {
                     HealthChangedEvent?.Invoke($"Health: {value}, Changed to: {value - Health}");
                    _health = value;
                }
                else
                {
                    _health = 0;
                    HealthChangedEvent?.Invoke("Unit died");
                }
            }
        }

        private double _damage;

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public event HealthChangedDelegate HealthChangedEvent;

        public void Attack(Unit unit)
        {
            unit.Health -= Damage;
        }
    }
}