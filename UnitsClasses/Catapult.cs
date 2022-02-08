using System;
using System.Collections.Generic;
using System.Text;
using UnitsInterfaces;

namespace UnitsClasses
{
    public class Catapult : BattleUnit, IRangeUnit
    {
        internal override bool IsCatapult => true;

        public int MinDamage { get => base.MinDamage; set => base.MinDamage = value; }
        public int MaxDamage { get => base.MaxDamage; set => base.MaxDamage = value; }
        public int MinRangeDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxRangeDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ammo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Catapult() : base("Catapult", 200, 20, 4, 10, 20)
        {
        }

        public override string ToString()
        {
            return $"{Name} Health: {Health}";
        }
    }
}
