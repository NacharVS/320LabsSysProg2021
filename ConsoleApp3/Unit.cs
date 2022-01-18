using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void UnitHealhtDelegate(string health);
		private double _health;
        public event UnitHealhtDelegate UnitHealthEvent;
        public double Health
		{
			get { return _health; }
			set {
                if (value > 0)
                {
                    _health = value;
                    UnitHealthEvent?.Invoke($"Current health {_health}");
                }
                }
		}

        private int _attack;

        public int Attack
        {
            get { return _attack; }
            set { 
                _attack = value;
                }
        }


    }
}
