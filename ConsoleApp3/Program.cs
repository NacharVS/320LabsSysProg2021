    using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(100);
            Console.WriteLine(character.Health);
            character.HealthChangedEvent += ShowMessage;
            character.Damage(40);
            character.Heal(20);
            character.Damage(100);
            Console.WriteLine(character.Health);
        }

         static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
