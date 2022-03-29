using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior w1 = new Warrior(100, 20, "Thomas");
            Warrior w2 = new Warrior(120, 20, "Tim");

            w1.HealthChangedEvent += Message;
            w2.HealthChangedEvent += Message;

            Battle bat = new Battle();

            bat.Fight(w1, w2);
        }

        static void Message(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
