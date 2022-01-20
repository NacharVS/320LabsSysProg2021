using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(50, 30);
            warrior.HealthChangedEvent += ShowMessage;
            Peasant peasant = new Peasant();
            peasant.HealthChangedEvent += ShowMessage;
            Console.WriteLine(warrior.Health);
            peasant.Attack(warrior);

        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

        // 1. create methods for imitation of battle between 2 units. All nonBuildingsunits can attack each other
        // 2. only catapult can attack building
        // 3. Units: Soldier(Only mlee attack), Archer(RangeAttack (has 5 arrows)),
        // All units Has AttackSpeed/WalkingSpeed. 

    }
}
