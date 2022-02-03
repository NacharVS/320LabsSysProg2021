using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : IBattleUnit, IMovingUnit
    {
        private int Arrows { get; set; }
        public double WalkingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AttackSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Archer(string name)
        {
            Arrows = 5;
        }

        public double RangeAttack()
        {
            if (Arrows > 0)
            {
                double presentDamage = (new Random()).Next(10,80);
                Arrows--;
                return presentDamage;
            }
            else
            {
                return MeleeAttack();
            }
        }

        public double MeleeAttack()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Message()
        {
            throw new NotImplementedException();
        }
    }
}
