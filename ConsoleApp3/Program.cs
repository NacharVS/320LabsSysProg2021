using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] array1 = new int[10];

            Task<int[]> taskGen = new Task<int[]>(() => Generation(array));

            //Task task2 = new Task(() => Summ(array));

            Task<int[]> taskContinue = taskGen.ContinueWith(doublearr => BinaryArray(doublearr.Result));

            taskGen.Start();
            taskContinue.Wait();
            array1 = taskContinue.Result;

            Console.WriteLine();

            foreach (var item in array1)
            {
                Console.Write(" " + item);
            }

            //taskContinue.Wait();

        }
        static int[] Generation(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2);
                Console.Write(array[i] + " ");
            }
            return array;
        }

        static void Summ(int[] array)
        {
            for (int i = 0; i < 10; i++)
            {               
                int summ = 0;
                foreach (var item in array)
                {
                    summ += item;
                }
                Console.WriteLine();
                Console.WriteLine("summ" + summ);
            }           
        }
        static int[] BinaryArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            return array;
        }
    }



}





