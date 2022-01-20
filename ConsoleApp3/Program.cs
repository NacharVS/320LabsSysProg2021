using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new Archer(50,10, 4, 10);
            Peasant peasant = new Peasant(500);
            Bishop bishop = new Bishop(100, 20, 2, 3);
            
            archer.HealthChangedEvent += ShowMessage;
            peasant.HealthChangedEvent += ShowMessage;
            bishop.HealthChangedEvent += ShowMessage;

            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
            Console.WriteLine(peasant.Health);
            archer.Attack(peasant, 10);
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
