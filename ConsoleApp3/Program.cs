using System;
using System.Threading;
using System.Reflection;
using System.ComponentModel.Design;
using UnitsInterfaces;
using UnitsClasses;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var warrior = new Warrior("warr", 100, 10, 10, 10, 50);
            warrior.HealthChangedEvent += ShowMessage;
            var warrior2 = new Warrior("warr 2", 200, 10, 10, 10, 50);
            warrior2.HealthChangedEvent += ShowMessage;

            Battle.Fight(warrior, warrior2);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}