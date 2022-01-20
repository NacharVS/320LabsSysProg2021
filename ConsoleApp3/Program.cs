using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior();
            warrior.HealthChangedEvent += ShowMessage;
            Peasant peasant = new Peasant();
            peasant.HealthChangedEvent += ShowMessage;
            Bishop bishop = new Bishop();
            bishop.HealthChangedEvent += ShowMessage;

            Console.WriteLine(warrior.Health);
            bishop.Attack(warrior);
            Console.WriteLine(warrior.Health);
        }
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0
        //3*. Implement method heal of bishop class. 
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
