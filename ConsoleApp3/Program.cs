﻿using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            war.HealthChangedEvent += ShowMessage;
            Peasant peas = new Peasant();
            peas.HealthChangedEvent += ShowMessage;
            Console.WriteLine(peas.Health);
            Bishop bish = new Bishop();
            bish.HealthChangedEvent += ShowMessage;
            Archer arch = new Archer();
            arch.HealthChangedEvent += ShowMessage;

            Battle fig = new Battle();

            fig.Fight(war, peas);


            //war.Attack(peas);
            //Console.WriteLine(peas.Health);
            //bish.Heal(peas);
            //Console.WriteLine(peas.Health);
            //war.Attack(peas);
            //Console.WriteLine(peas.Health);
            //arch.Attack(peas);
            //Console.WriteLine(peas.Health);
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
