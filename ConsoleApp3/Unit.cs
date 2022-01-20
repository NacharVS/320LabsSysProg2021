using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		private double _health;
		public delegate void HpChangedDelegate(string message);

		public double Hp
		{
			get { return _health; }
			set
			{
				if (value > 0)
				{
					HpChangedEvent?.Invoke($"HealthPoints has changed {value - _health}");
					_health = value;

				}
				else
				{
					_health = 0;
					HpChangedEvent?.Invoke("Dead");
				}
			}
		}
		public event HpChangedDelegate HpChangedEvent;

	}
}
