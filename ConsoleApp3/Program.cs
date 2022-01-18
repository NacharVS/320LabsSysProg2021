using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Warrior warrior = new Warrior();
            Peasant peasant = new Peasant();
            Bishop bishop = new Bishop();

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
