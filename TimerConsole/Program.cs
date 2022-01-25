using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Task timer1 = new Task(() => StartTimer(10, "timer1", 0));
            Task timer2 = new Task(() => StartTimer(10, "timer2", 0));

            Task timer3 = timer1.ContinueWith(time => StartTimer(10, "timer3", 0));
            Task timer4 = timer2.ContinueWith(time => StartTimer(10, "timer4", 0));

            Task timer5 = timer1.ContinueWith(time => StartTimer(10, "timer5", 5));
            Task timer6 = timer2.ContinueWith(time => StartTimer(10, "timer6", 5));

            timer1.Start();
            timer2.Start();

            Console.ReadKey();
        }
        static void StartTimer(int time, string timer, int delayTime)
        {
            Thread.Sleep(delayTime * 1000);
            while (time > 0)
            {
                Console.WriteLine($"{timer} {time}");
                Thread.Sleep(1000);
                time--;
            }

            Console.WriteLine($"{timer} Время закончилось");
        }

    }
}