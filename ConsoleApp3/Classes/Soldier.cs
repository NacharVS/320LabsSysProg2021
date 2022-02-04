using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Classes
{
    class Soldier : Unit
    {
        private double _damage;

        public void Attack(Unit unit)
        {
            if (_damage >= 0)
                unit.Hp -= _damage;

        }
        public Soldier()
        {
            Hp = 110;
            _damage = 40;
            ASpeed = 10;
            WSpeed = 7;
        }
        public Soldier(double health)
        {
            Hp = health;
        }
    }
