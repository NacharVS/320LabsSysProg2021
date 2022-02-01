using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier Bob = new Soldier(new Sword());
            Bob.weapon.InflictDamage();
            Blacksmith Ivan = new Blacksmith();
            var weaponX = Ivan.MakeBow();
            Bob.weapon = weaponX;
            Bob.weapon.InflictDamage();
            var weaponY = Ivan.MakeJavelin();
            Bob.weapon = weaponY;
            Bob.weapon.InflictDamage();
            Bob.Throw(weaponY);
            B



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
    // Создать 6 таймеров с 30 секундным промежутком времени.
    // Певый и второй стартуют одновременно, третий и четвертый по истечению первых двух. Пятый и шестой в момент когда на 3 и 4 осталось 15 секунд.
    // При истечении временного отрезка, рядом с таймером выскакивает строка Время всё
    // 


}





