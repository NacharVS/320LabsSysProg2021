using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.UnitInterface
{
	interface IBattlebleUnit : IUnit
	{
		int damage { get; }
		int AttackSpeed { get;}
		 void attack(Unit unit);
    }
}
