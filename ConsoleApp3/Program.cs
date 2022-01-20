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
            Soldier soldier = new Soldier();
            Archer archer = new Archer();

            warrior.HealthChanerEvent += ShowMessage;
            soldier.HealthChanerEvent += ShowMessage;
            archer.HealthChanerEvent += ShowMessage;
            soldier.Damage(warrior);
            archer.Damage(soldier);
            warrior.Damage(archer);
            
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
