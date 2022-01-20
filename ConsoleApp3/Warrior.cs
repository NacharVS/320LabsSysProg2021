using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        private int _damage;

        public override void Dead()
        {
            Console.WriteLine($"Warrior Dead");
        }

        public override void Defense()
        {
            Health -= DamageTaken;
            Console.WriteLine($"Remaining health - {Health}");
        }

        public override int Attack()
        {
            _damage = random.Next(1, 10);
            Console.WriteLine($"Warrior Attack - {_damage}");
            DamageTaken += _damage;
            return _damage;
            //if (Alive(_damage, Health))
            //{
            //    Health -= _damage;
            //    Console.WriteLine($"Warrior Attack - {_damage}");
            //    Console.WriteLine($"Remaining health - {Health}");
            //}
            //else
            //{
            //    Console.WriteLine($"Warrior Attack - {_damage}");
            //    Dead();
            //}
        }
    }
}
