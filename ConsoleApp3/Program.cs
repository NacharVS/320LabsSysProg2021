using System;
using System.Reflection;
using System.ComponentModel.Design;
using System.Threading;
using Core;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            Archer archer = new Archer("Igor");
            Warrior warrior = new Warrior("Iking");
            Catapult catapult = new Catapult("Angel");
            Building building = new Building("Taverna", 80);
            Console.WriteLine(battle.Fight(building, catapult));
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
