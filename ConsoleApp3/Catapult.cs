using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	class Catapult:Unit
	{
        private double _damage;
        private double _projectile;
        public void Shot(Unit unit)
        {
            if (_damage >= 0 && _projectile != 0)
            {
                unit.Hp -= _damage;
                _projectile--;
            }
            else
            {
                Console.WriteLine("the projectile are out");
            }
        }
        public Catapult()
        {
            Hp = 170;
            _damage = 50;
            _projectile = 10;
            ASpeed = 5;
            WSpeed = 7;
        }
        public Catapult(double health)
        {
            Hp = health;
        }
    }
}
