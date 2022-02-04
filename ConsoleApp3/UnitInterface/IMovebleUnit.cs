using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.UnitInterface
{
	interface IMovebleUnit : IUnit
	{
		int WalkSpeed { get; }
		void move();
	}
}
