using System;
using System.Collections.Generic;
using System.Text;

namespace UnitInterfaces
{
    public interface IBattleUnit : IUnit
    {
        double AttackSpeed { get;set; }
        double Damage { get; set; }
        double MeleeAttack();
        bool IsCatapult { get;  }
        void Attack(IBattleUnit unit, double damage);
    }
}
