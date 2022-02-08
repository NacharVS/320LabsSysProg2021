using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static string MakeCream()
        {
            Thread.Sleep(5000);
            Console.WriteLine("cream ready");
            return "CreamForCake";
        }
        static async Task MakeCreamAsync()
        {
            await Task.Run(() => MakeCream());
        }

        static string MakeChicken()
        {
            Console.WriteLine("chicken ready");
            return "Chicken";
        }
        static string MakeKebab()
        {
            Thread.Sleep(7000);
            Console.WriteLine("kebab ready");
            return "kebab";
        }

        static async Task MakeCakeAsync()
        {

        }

        static async Task MakeKebabAsync()
        {
           await Task.Run(() => MakeKebab());
        }
        static string MakeKorjes()
        {
            Thread.Sleep(10000);
            Console.WriteLine("korjes ready");
            return "korjes";
        }

        static async Task MakeKorjesAsync()
        {
            await Task.Run(() => MakeKorjes());
        }
        static string MakeCake()
        {
            MakeKebabAsync().GetAwaiter();
            MakeCreamAsync().GetAwaiter();
            MakeKorjesAsync().GetAwaiter().GetResult();
            Console.WriteLine("cake ready");
            return "cake";
        }
        static void Cleaning()
        {
            Console.WriteLine("Cleaning comlete");
        }
        static void Main(string[] args)
        {
            MakeCake();

            Console.ReadKey();



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
    // Реализовать WPF приложение 
    // с асинхронным получением данных в отображаемый на форме список. 


}





