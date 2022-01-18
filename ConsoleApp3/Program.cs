using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            Peasant peasant = new Peasant();

            warrior.HealthChandgedEvent += ShowMessage;
            warrior.Hit(peasant);
            warrior.Hit(peasant);
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
