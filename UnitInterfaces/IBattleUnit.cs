﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitInterfaces
{
    public interface IBattleUnit : IUnit
    {
        double AttackSpeed { get; }
        double Damage { get; }
        double MeleeAttack();
        bool IsCatapult { get;  }
        void Attack(IBattleUnit unit);
    }
}