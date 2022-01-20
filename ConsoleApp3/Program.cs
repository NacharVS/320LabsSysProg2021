using System;
using System.Threading;
using Core;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier sold = new Soldier("Semen");
            //sold.HealtChangedEvent += ShowMessage;

            Archer arc = new Archer("Anton");
            arc.HealtChangedEvent += ShowMessage;

            Peasant peas = new Peasant("Sasha");
            peas.HealtChangedEvent += ShowMessage;

            Bishop bishop = new Bishop("Anna", 20);
            bishop.HealtChangedEvent += ShowMessage;

            Building building = new Building("Build", 80);
            building.HealtChangedEvent += ShowMessage;

            Catapult cat = new Catapult();

            Battle bat = new Battle();
            bat.Fighting(sold, arc);

            //bat.Fighting(building, cat);
            //bishop.Heal(sold);

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
