using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal abstract class Unit
    {
        internal delegate void GetDamageDelegate(string message);

        private double _maxHeal;

        public double MaxHealth
        {
            get => _maxHeal;
            set => _maxHeal = value;
        }

        private double _health;

        public double Health
        {
            get => _health;
            set
            {
                if(value > 0)
                {
                    if (value >= MaxHealth)
                        _health = MaxHealth;
                    else
                    {
                        _health = value;
                    }
                    GetDamageEvent?.Invoke($"Your HP: {_health}");
                }
                else
                {
                    _health = 0;
                    GetDamageEvent?.Invoke("Your're dead");
                }
            }
        }

        internal event GetDamageDelegate GetDamageEvent;
    }
}
