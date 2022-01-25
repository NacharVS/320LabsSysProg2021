using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Task timer1 = new Task(() => TimerStart(1));
            Task timer2 = new Task(() => TimerStart(2));

            Task timer5 = new Task(() => TimerStart(5));
            Task timer6 = new Task(() => TimerStart(6));

            Task timer3 = timer2.ContinueWith(t => TimeWaitHalf(3, timer5));
            Task timer4 = timer2.ContinueWith(t => TimeWaitHalf(4, timer6));

            timer1.Start();
            timer2.Start();
            timer3.Wait();
            timer4.Wait();
            timer5.Wait();
            timer6.Wait();
        }

        static void TimerStart(int timerNum)
        {
            for (int i = 30; i > 0; i--)
            {
                Console.WriteLine($"timer {timerNum} {i}");
                Thread.Sleep(500);
            }
            Thread.Sleep(500);
        }

        static void TimeWaitHalf(int timerNum, Task timer)
        {
            for (int i = 30; i >= 15; i--)
            {
                Console.WriteLine($"timer {timerNum} {i}");
                Thread.Sleep(500);
            }
            Thread.Sleep(500);
            timer.Start();

            for (int i = 14; i > 1; i--)
            {
                Console.WriteLine($"timer {timerNum} {i}");
                Thread.Sleep(500);
            }
            Thread.Sleep(500);
            Console.WriteLine($"timer {timerNum} seconds have passed");
        }

    }
}
