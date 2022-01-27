using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Peasant peasant = new Peasant();
            peasant.HpChangedEvent += ShowMessage;
            Warrior warrior = new Warrior();
            warrior.HpChangedEvent += ShowMessage;
            Bishop bishop = new Bishop();
            bishop.HpChangedEvent += ShowMessage;
            Archer archer = new Archer();
            archer.HpChangedEvent += ShowMessage;

            warrior.Attack(peasant);
            Console.WriteLine(peasant.Hp);
            bishop.Heal(peasant);
            Console.WriteLine(peasant.Hp);
            warrior.Attack(bishop);
            Console.WriteLine(bishop.Hp);
            warrior.Attack(peasant);
            Console.WriteLine(peasant.Hp);
            archer.Shot(warrior);
            Console.WriteLine(warrior.Hp);
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        // 1. create methods for imitation of battle between 2 units. All nonBuildingsunits can attack each other

         

    }
}
