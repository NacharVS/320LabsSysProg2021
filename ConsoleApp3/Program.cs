using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(50);
            Peasant peasant = new Peasant(100);
            Bishop bishop = new Bishop(100, 20);
            
            warrior.HealthChangedEvent += ShowMessage;
            peasant.HealthChangedEvent += ShowMessage;
            bishop.HealthChangedEvent += ShowMessage;

            Console.WriteLine(peasant.Health);
            warrior.Attack(peasant, 70);
            Console.WriteLine(peasant.Health);
            bishop.Heal(peasant);
            Console.WriteLine(peasant.Health);
        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
