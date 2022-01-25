using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task firstTask = new Task(() => RunTimer(30));
            Task secondTask = new Task(() => RunTimer(30));
            Task fifthTask = new Task(() => RunTimer(30));
            Task sixthTask = new Task(() => RunTimer(30));
            Task thirdTask = firstTask.ContinueWith(timer => RunTimer(30, fifthTask, 15));
            Task fourthTask = secondTask.ContinueWith(timer => RunTimer(30, sixthTask, 15));

            firstTask.Start();
            secondTask.Start();
            Console.ReadKey();
        }

        static void RunTimer(int seconds)
        {
            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
            Console.WriteLine("You out of time");
        }

        static void RunTimer(int seconds, Task firstTask, int whenStart)
        {
            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                if (i == whenStart)
                {
                    firstTask.Start();
                }
            }

            Console.WriteLine("You out of time");
        }
        //Warrior warrior = new Warrior();
        //Peasant peasant = new Peasant();
        //Cleric cleric = new Cleric(); 

        //Console.WriteLine($"Peasant's HP: {peasant.Health}");

        //peasant.GetDamageEvent += ShowMessage;
        //cleric.GetDamageEvent += ShowMessage;

        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);
        //peasant.Health = ToDamageHero(peasant.Health, warrior.Damage);

        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();
        //peasant.Health += cleric.ToHeal();


        ////-----------------------------------------------------------------------
        //static double ToDamageHero(double health, double damage)
        //{
        //   return health -= damage;
        //}
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
