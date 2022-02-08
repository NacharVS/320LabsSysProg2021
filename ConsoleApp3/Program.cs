using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Archer archer = new Archer("arc", 50);
            Warrior warrior = new Warrior("war", 50);

            Battle battle = new Battle();

            Console.WriteLine(battle.Fight(archer, warrior));
        }
    }
}
