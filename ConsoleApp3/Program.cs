using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Peasant peasant = new Peasant();

            
            warrior.HealthChanerEvent += ShowMessage;
            warrior.Damage(peasant);

            
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
