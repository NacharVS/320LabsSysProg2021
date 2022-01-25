using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 30;

            Task<int> timer1 = new Task<int>(() => GenerationTimer(time));
            Task<int> timer2 = new Task<int>(() => GenerationTimer(time));

            Task<int> timer3 = timer1.ContinueWith(doub => GenerationTimer(doub.Result));
            Task<int> timer4 = timer1.ContinueWith(doub => GenerationTimer(doub.Result));

            Task<int> timer5 = timer1.ContinueWith(doub => HalfTimer(doub.Result / 2));
            Task<int> timer6 = timer1.ContinueWith(doub => HalfTimer(doub.Result / 2));

            timer1.Start();
            timer2.Start();

            timer3.Wait();
            timer4.Wait();

            timer5.Wait();
            timer6.Wait();
        }

        static int GenerationTimer(int time)
        {
            int[] array = new int[time];
            Console.WriteLine("Started Timer");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.Write(array[i] + "  ");
                Thread.Sleep(100);
            }
            //Console.WriteLine();
            Console.WriteLine("Timer expired");
            return time;
        }

        static int HalfTimer(int time)
        {
            int[] array = new int[time];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                //Console.Write(array[i] + "  ");
                Thread.Sleep(100);
            }
            GenerationTimer(time * 2);
            return time;
        }
    }
}

