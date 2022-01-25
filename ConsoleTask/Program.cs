using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tim1 = new Task(() => TimeBegin("Timer1",10));
            Task tim2 = new Task(() => TimeBegin("Timer2",10));

            Task tim5 = new Task(() => TimeBegin("Timer5", 10));
            Task tim6 = new Task(() => TimeBegin("Timer6",10));

            Task tim3 = tim1.ContinueWith(t => TimeBegin("Timer3", 6, tim5));
            Task tim4 = tim2.ContinueWith(t => TimeBegin("Timer4",6, tim6));

            tim1.Start();
            tim2.Start();

            Console.ReadLine();
        }
        public static void TimeBegin(string nameTim,int second)
        {
            Thread.Sleep(second * 1000);
            Console.WriteLine($"{nameTim} {second} time is everything");
        }

        public static void TimeBegin(string nameTim,int sec, Task tim)
        {
            Thread.Sleep(sec / 2 * 1000);
            tim.Start();
            Console.WriteLine($"{nameTim} {sec / 2} time is everything");
            Thread.Sleep(sec / 2 * 1000);
            Console.WriteLine($"{nameTim} {sec} time is everything");
        }
    }
}
