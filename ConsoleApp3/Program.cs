using System;
using System.Threading;
using System.Reflection;
using System.ComponentModel.Design;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var catapult = new Catapult();
            var archer = new Archer("Archer");
            var building = new Building("Tower", 100, 100);
            var soldier = new Soldier("Soldier");

            catapult.HealthChangedEvent += ShowMessage;
            archer.HealthChangedEvent += ShowMessage;
            building.HealthChangedEvent += ShowMessage;
            soldier.HealthChangedEvent += ShowMessage;

            Battle.Fight(archer, soldier);
            //Battle.Fight(building, catapult);
            //Battle.Fight(building, archer);
            //Battle.Fight(catapult, archer);


        }
        // 1. create methods for imitation of battle between 2 units. All nonBuildingsunits can attack each other
        // 2. only catapult can attack building
        // 3. Units: Soldier(Only mlee attack), Archer(RangeAttack (has 5 arrows)),
        // All units Has AttackSpeed/WalkingSpeed. 

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}