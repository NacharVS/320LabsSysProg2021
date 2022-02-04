using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	class Catapult:Unit, UnitInterface.IDistant, UnitInterface.IMovebleUnit

    {
        public int damage => 100;
        public int AttackSpeed => 5;
        public int WalkSpeed => 5;
        private int _projectile;
        public void move()
        {

        }
        public void attack(Unit unit)
        {
            if (damage >= 0 && _projectile != 0)
            {
                unit.Hp -= damage;
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
            _projectile = 10;
        }
        public Catapult(double health)
        {
            Hp = health;
        }
    }
}
