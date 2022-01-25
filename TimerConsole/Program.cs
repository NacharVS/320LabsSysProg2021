using System;
using System.Threading;
using System.Threading.Tasks;

namespace TimerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Task timer1 = new Task(() => StartTimer("timer1", 30, 0));
            Task timer2 = new Task(() => StartTimer("timer2", 30, 0));
            Task timer3 = timer1.ContinueWith(t3 => StartTimer("timer3", 30, 0));
            Task timer4 = timer2.ContinueWith(t4 => StartTimer("timer4", 30, 0));
            Task timer5 = timer1.ContinueWith(t5 => StartTimer("timer5", 30, 15));
            Task timer6 = timer1.ContinueWith(t6 => StartTimer("timer6", 30, 15));

            timer1.Start();
            timer2.Start();
            Console.ReadKey();
        }

        public static void StartTimer(string name, int time, int delay)
        {
            Thread.Sleep(delay * 1000);
            while (time > 0)
            {
                Console.WriteLine($"{name}:{time}");
                --time;
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{name} finish !!!");
        }
    }
}
