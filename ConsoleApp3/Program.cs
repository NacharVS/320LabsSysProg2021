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
            Bishop bishop = new Bishop();
            
            warrior.Health = 100;

            warrior.HealthChanerEvent += ShowMessage;
            warrior.Damage(peasant);
            bishop.DoHeal(peasant);

            
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
