using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	class Archer : Unit
	{
		private double _damage;
        private double _arrow;
        public void Shot(Unit unit)
        {
            if (_damage >= 0 && _arrow != 0)
            {
                unit.Hp -= _damage;
                _arrow--;
            }
            else 
            {
                Console.WriteLine("A-A-A-A-A-A damn, the arrows are out");
            }
        }
        public Archer()
        {
            Hp = 70;
            _damage = 10;
            _arrow = 5;
            ASpeed = 15;
            WSpeed = 25;
        }
        public Archer(double health)
        {
            Hp = health;
        }
    }
}
