using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit, UnitInterface.IMovebleUnit, UnitInterface.IBattlebleUnit
    {
        public int damage => 10;
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
        public Warrior()
        {
            Hp = 90;

        }
        public Warrior(double health)
        {
            Hp = health;
        }
    }
}
