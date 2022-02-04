using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Classes
{
    class Soldier : Unit, UnitInterface.IMelee, UnitInterface.IMovebleUnit
    {
        public int damage => 50;
        public int AttackSpeed => 20;
        public int WalkSpeed => 15;

        public void move() 
        {

        }

        public void attack(Unit unit)
        {
            if (damage >= 0)
                unit.Hp -= damage;

        }
        public Soldier()
        {
            Hp = 110;

        }
        public Soldier(double health)
        {
            Hp = health;
        }
    }
}
