﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior1 = new Warrior("Bob", 200, 10, 10, 10, 50);
            Warrior warrior2 = new Warrior("Cliff", 200, 10, 10, 10, 50);
            warrior1.HealthChangedEvent += ShowMessage;
            warrior2.HealthChangedEvent += ShowMessage;
            Battle.Fight(warrior1, warrior2);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);

        }
    }
}