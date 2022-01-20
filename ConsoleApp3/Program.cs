using System;
using System.Reflection;
using System.ComponentModel.Design;
using System.Threading;
using Core;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            Archer archer = new Archer("Klim");
            Warrior warrior = new Warrior("Warrior");
            Catapult catapult = new Catapult("Catapult");
            Building building = new Building("Tower", 80);
            Console.WriteLine(battle.Fight(archer, warrior));
            Console.WriteLine(battle.Fight(building, catapult));
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
