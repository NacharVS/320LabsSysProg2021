using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Warrior warrior = new Warrior("Gleb");
            Peasant peasant = new Peasant("Ivam");
            Bishop bishop = new Bishop("Hristos", 5);

            warrior.HealthChandgedEvent += ShowMessage;
            warrior.Hit(peasant);
            Console.WriteLine();
            warrior.Hit(peasant);


            bishop.HealingChandgedEvent += ShowMessage;
            Console.WriteLine();
            bishop.Heal(peasant);
            Console.WriteLine();

        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
