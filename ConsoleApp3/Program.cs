using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task timer1 = new Task(() => Timer(1));
            Task timer2 = new Task(() => Timer(2));

            Task timer5 = new Task(() => Timer(5));
            Task timer6 = new Task(() => Timer(6));

            Task timer3 = timer2.ContinueWith(x => ModifiedTimer(3, timer5));
            Task timer4 = timer2.ContinueWith(x => ModifiedTimer(4, timer6));

            timer1.Start(); 
            timer2.Start();
            timer3.Wait();
            timer4.Wait();
            timer5.Wait();
            timer6.Wait();
        }

        static void Timer(int timerNumber)
        {
            for (int i = 30; i > 0; i--)
            {
                Console.WriteLine($"таймер {timerNumber}: {i}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"таймер {timerNumber} всё");
        }

        static void ModifiedTimer(int timerNumber, Task timer)
        {
            for (int i = 30; i >= 15; i--)
            {
                Console.WriteLine($"таймер {timerNumber}: {i}");
                Thread.Sleep(500);
            }
            timer.Start();
            for (int i = 14; i > 1; i--)
            {
                Console.WriteLine($"таймер {timerNumber}: {i}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"таймер {timerNumber} всё");
        }
    }
}
