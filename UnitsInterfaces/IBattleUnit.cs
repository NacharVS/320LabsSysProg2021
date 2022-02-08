using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsInterfaces
{
    public interface IBattleUnit : IUnit
    {
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        double MeleeAttack(Random rnd)
        {
            return rnd.Next(MinDamage, MaxDamage);
        }
        double Attack(Random rnd)
        {
             return MeleeAttack(rnd);
        }
    }
}
