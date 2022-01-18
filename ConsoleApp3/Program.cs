using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior(110,80);
            war.HealtChangedEvent += ShowMessage;

            Peasant peas = new Peasant();
            peas.HealtChangedEvent += ShowMessage;

            Bishop bishop = new Bishop(150, 10);
            bishop.HealtChangedEvent += ShowMessage;

            bishop.Heal(war);
            war.Attack(peas);
        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
        //static double 
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
