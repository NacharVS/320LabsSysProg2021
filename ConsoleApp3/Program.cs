using System;
using System.Threading;
using ConsoleApp3.Models;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Peasant peasant = new Peasant();
            Cleric cleric = new Cleric(); 

            Console.WriteLine($"Peasant's HP: {peasant.Health}");

            peasant.GetDamageEvent += ShowMessage;
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
            peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);




            //-----------------------------------------------------------------------
            static double ToDamageHero(double health, double damage)
            {
               return health -= damage;
            }
        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
        static void ShowMessage1(string mes)
        {
            Console.WriteLine(mes+mes);
        }
    }
}
