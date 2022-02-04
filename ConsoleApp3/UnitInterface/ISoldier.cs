using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.UnitInterface
{
	interface ISoldier : IUnit, IMovebleUnit, IBattlebleUnit
	{
		public void attack(Unit unit)
        {
            if (damage >= 0)
            {
                unit.Hp -= damage;
            }
        }
    }
}
