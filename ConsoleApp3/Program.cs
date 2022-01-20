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
            Archer archer = new Archer("Igor");
            Warrior warrior = new Warrior("Iking");
            Console.WriteLine(battle.Fight(archer, warrior));
        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
