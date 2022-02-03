using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IBattleUnit
    {
        double AttackSpeed { get;set; }
        double Damage { get; set; }
        double MeleeAttack();
    }
}
