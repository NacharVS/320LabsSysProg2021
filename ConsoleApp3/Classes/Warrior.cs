using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        private double _damage;
        public void Attack(Unit unit)
        {
            if (_damage >= 0)
                unit.Hp -= _damage;

        }
        public Warrior()
        {
            Hp = 90;
            _damage = 20;
        }
        public Warrior(double health)
        {
            Hp = health;
        }
    }
}
