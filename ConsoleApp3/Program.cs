using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            Peasant peas = new Peasant();

            war.HealthChandgedEvent += ShowMessage;
            war.Hit(peas);
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
