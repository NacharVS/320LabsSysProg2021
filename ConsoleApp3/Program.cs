using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit war = new Warrior();
            Unit peas = new Peasant();

            war.Health = 10;
            peas.Health = 10;

            war.Attack();
            peas.Defense();
            peas.Attack();
            war.Defense();
        }
        // 1. create methods for imitation of battle between 2 units. All nonBuildingsunits can attack each other
        // 2. only catapult can attack building
        // 3. Units: Soldier(Only mlee attack), Archer(RangeAttack (has 5 arrows)),
        // All units Has AttackSpeed/WalkingSpeed. 

    }
}
