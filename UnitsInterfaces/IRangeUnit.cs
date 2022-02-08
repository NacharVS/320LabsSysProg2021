using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsInterfaces
{
    public interface IRangeUnit: IBattleUnit
    {
        int MinRangeDamage { get; set; }
        int MaxRangeDamage { get; set; }
        int Ammo { get; set; }

        public double RangeAttack(Random rnd)
        {
            if (Ammo > 0)
            {
                Ammo--;
                return rnd.Next(MinRangeDamage, MaxRangeDamage);
            }
            else
            {
                return MeleeAttack(rnd);
            }
        }
        new double Attack(Random rnd)
        {
            return RangeAttack(rnd);
        }
    }
}
