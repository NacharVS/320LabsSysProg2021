using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit Bob = new Unit(new Sword(), 10);
            Unit Max = new Unit(new Sword(), 10);
            Bob.weapon.InflictDamage(Max);
            Console.WriteLine(Max._health);
            var newBow = new Weapon.Bow();
            Max.weapon = newBow;
            Max.weapon.InflictDamage(Bob);
            Console.WriteLine(Bob._health);

            //war.Attack(peas);
            //Console.WriteLine(peas.Health);
            //bish.Heal(peas);
            //Console.WriteLine(peas.Health);
            //war.Attack(peas);
            //Console.WriteLine(peas.Health);
            //arch.Attack(peas);
            //Console.WriteLine(peas.Health);
        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
