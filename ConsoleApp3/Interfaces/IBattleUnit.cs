using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    public interface IBattleUnit : IUnit
    {
        double Damage { get; }
        double AttackSpeed { get; }
        bool IsCatapult { get; }

        void MleeAttack(IUnit unit);
        void Attack(IUnit unit);
    }
}
