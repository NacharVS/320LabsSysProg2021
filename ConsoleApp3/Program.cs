using ConsoleApp3.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.Globalization;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{


    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("Bob");

            //TypeInfo t = typeof(IBattleUnit).GetTypeInfo();
            //IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
            //IEnumerable<MethodInfo> mList = t.DeclaredMethods;
            //StringBuilder sb = new StringBuilder();

            //sb.Append("Properties:");
            //foreach (PropertyInfo p in pList)
            //{

            //    sb.Append("\n" + p.DeclaringType.Name + ": " + p.Name);
            //}
            //sb.Append("\nMethods:");
            //foreach (MethodInfo m in mList)
            //{
            //    sb.Append("\n" + m.DeclaringType.Name + ": " + m.Name);
            //}

            //Console.WriteLine(sb.ToString());




            //Warrior war2 = new Warrior("Kirill");
            //Peasant peas = new Peasant("Jimmy");
            Archer arch = new Archer("Salavat");
            //Archer arch2 = new Archer("Salavat2");
            Bishop bish = new Bishop("Diyar");
            Catapult catapult = new Catapult("Cat");
            Tower tower = new Tower("Tower");
            
            //war.AttackUnit(peas);
            Battle bat = new Battle(war, arch, 0);


        }

        static void attackUnit(Unit attacker, Unit defender)
        {
           // defender.Health -= attacker.Damage;
        }

        
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
