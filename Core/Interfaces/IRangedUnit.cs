using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRangedUnit : IUnit
    {
        double Ammo { get; set; }
        double RangeDamage { get; }
        void RangeAttack(IUnit unit);
    }
}
