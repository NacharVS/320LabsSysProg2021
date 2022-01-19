﻿using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("Semen");
            war.HealtChangedEvent += ShowMessage;

            Peasant peas = new Peasant("Sasha");
            peas.HealtChangedEvent += ShowMessage;

            Bishop bishop = new Bishop("Anna", 20);
            bishop.HealtChangedEvent += ShowMessage;

            bishop.Heal(war);
            war.Attack(peas);
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
