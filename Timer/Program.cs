using System;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Task timer1 = new Task(() => TimeWait(10));
            Task timer2 = new Task(() => TimeWait(10));

            Task timer5 = new Task(() => TimeWait(10));
            Task timer6 = new Task(() => TimeWait(10));

            Task timer3 = timer1.ContinueWith(t => TimeWaitHalf(6, timer5));
            Task timer4 = timer2.ContinueWith(t => TimeWaitHalf(6, timer6));

            timer1.Start();
            timer2.Start();

            Console.ReadLine();
        }
        public static void TimeWait(int sec)
        {
            Thread.Sleep(sec * 1000);
            Console.WriteLine($"{sec} seconds have passed");
        }

        public static void TimeWaitHalf(int sec, Task timer)
        {
            Thread.Sleep(sec / 2 * 1000);
            timer.Start();
            Console.WriteLine($"{sec / 2} seconds have passed");
            Thread.Sleep(sec / 2 * 1000);
            Console.WriteLine($"{sec} seconds have passed");
        }
    }
}