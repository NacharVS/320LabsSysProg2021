using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            Peasant peas = new Peasant();
            Bishop bish = new Bishop();

            peas.HealthChandgedEvent += ShowMessage;
            war.Hit(peas);
            bish.Heal(peas);
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
