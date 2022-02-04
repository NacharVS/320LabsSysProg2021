using System;
using System.Reflection;
using System.ComponentModel.Design;
using System.Threading;
using Core.Units;
using Core.Interfaces;
using Core;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new Archer("Biba");
            Warrior warrior = new Warrior("Boba");
            Building building = new Building("Buba");
            Catapult catapult = new Catapult("Egor");

            Battle battle = new Battle();

            Console.WriteLine(battle.Fight(catapult, building));
            Console.WriteLine("------------------------------");
            Console.WriteLine(battle.Fight(archer, warrior));
        }
    }
}
