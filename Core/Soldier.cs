using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Core
{
    public class Soldier : IBattleUnit, IMovingUnit
    {
        public double AttackSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double WalkingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Soldier(string name)/* : base(name,100,10,5,2)*/
        {

        }
        public double MeleeAttack()
        {
            if (Health > 0.4 * MaxHealth)
            {
                //return base.MeleeAttack();
                throw new NotImplementedException();
            }
            else
            {
                //return base.MeleeAttack() * 2;
                throw new NotImplementedException();
            }
        }
    }
}
