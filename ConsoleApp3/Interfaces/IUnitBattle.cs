using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IUnitBattle : IUnit
    {
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        double MeleeAttack(Random rnd)
        {
            return rnd.Next(MinDamage, MaxDamage);
        }
    }
}
