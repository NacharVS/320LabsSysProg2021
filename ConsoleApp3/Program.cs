using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Ivan";
            std.Group = 333;
            Console.WriteLine(std.Group);
            std.GroupChandgedEvent += ShowMessage;
            std.GroupChandgedEvent += ShowMessage1;
            std.Group = 331;
            Console.WriteLine(std.Group);
        }

         static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
        static void ShowMessage1(string mes)
        {
            Console.WriteLine(mes+mes);
        }
    }
}
