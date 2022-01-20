using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Unit
    {
		public Random random = new Random();
		private int _damageTaken;
		private int _health;

		public int DamageTaken
        {
			get { return _damageTaken; }
			set { _damageTaken = value; }
		}

		public int Health
		{
			get { return _health; }
			set { _health = value; }
		}

		public abstract int Attack();

		public abstract void Dead();

		public abstract void Defense();

		public bool Alive(int damage, int health)
        {
			return health > damage;
        }
	}
}
