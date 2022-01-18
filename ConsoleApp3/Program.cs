using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            Peasant peas = new Peasant();
            peas.HealtChangedEvent += ShowMessage;
            war.HealtChangedEvent += ShowMessage;

            Console.WriteLine(peas.Health);
        }
        static void ShowMessage(string mes)
        {
            Console.Write(mes);
        }
        //static double 
        // 1. create methods for inflict damage
        // 2. health value can not be less than 0

    }
}
