using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.UnitInterface
{
	interface IBattlebleUnit : IUnit
	{
		int damage { get; set; }
		public void attack();
    }
}
