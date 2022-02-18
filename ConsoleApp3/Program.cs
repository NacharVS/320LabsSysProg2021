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
            Build build = new Build();
            Catapult catapult = new Catapult();

            warrior.HealthChanerEvent += ShowMessage;
            soldier.HealthChanerEvent += ShowMessage;
            archer.HealthChanerEvent += ShowMessage;
            build.HealthChanerEvent += ShowMessage;
            catapult.HealthChanerEvent += ShowMessage;
            peasant.HealthChanerEvent += ShowMessage;
            bishop.HealthChanerEvent += ShowMessage;

            archer.Damage(build);
            catapult.Damage(build);
            warrior.Damage(peasant);
            bishop.DoHeal(peasant);
            archer.Damage(bishop);
            bishop.DoHeal(bishop);
            
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
