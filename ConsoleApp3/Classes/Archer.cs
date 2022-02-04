using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	class Archer : Unit, UnitInterface.IDistant, UnitInterface.IMovebleUnit 
	{
        public int damage => 30;
        public int AttackSpeed => 20;
        public int WalkSpeed => 15;
        private double _arrow;

        public void move()
        {

        }
        public void attack(Unit unit)
        {
            if (damage >= 0 && _arrow != 0)
            {
                unit.Hp -= damage;
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
            _arrow = 5;
        }
        public Archer(double health)
        {
            Hp = health;
        }
    }
}
