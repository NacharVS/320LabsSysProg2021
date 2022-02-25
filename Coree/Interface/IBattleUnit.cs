using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Coree.Interface
{
    class IBattleUnit : IUnit 
    {
        double Damage { get; }
        double AttackSpeed { get; }

        void MeleeAttack(IUnit unit);
        void Attack(IUnit unit);
    }
}
