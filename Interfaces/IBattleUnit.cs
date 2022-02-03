using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IBattleUnit : IUnit
    {
        double AttackSpeed { get;set; }
        double Damage { get; set; }
        double MeleeAttack();
        void Attack(IBattleUnit unit, double damage);
    }
}
