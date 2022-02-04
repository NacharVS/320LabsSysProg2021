using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBattleUnit : IUnit
    {
        double Damage { get; }
        double AttackSpeed { get; }

        void MeleeAttack(IUnit unit);
        void Attack(IUnit unit);
    }
}
