using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            war.HealthChangedEvent += ShowMessage;
            Peasant peas = new Peasant();
            peas.HealthChangedEvent += ShowMessage;
            Console.WriteLine(peas.Health);
            Bishop bish = new Bishop();
            bish.HealthChangedEvent += ShowMessage;

            war.Attack(peas, 5);
            Console.WriteLine(peas.Health);
            bish.Heal(peas, 200);
            Console.WriteLine(peas.Health);
            war.Attack(peas, 46);
            Console.WriteLine(peas.Health);
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
