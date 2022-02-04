using System;
using System.Threading;
using Core;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier sold = new Soldier("Semen",6,40);
            Archer arc = new Archer("Bob",10,20);
            Archer arc2 = new Archer("Sasha", 20, 40);
            Battle battle = new Battle();
            battle.Fighting(arc, arc);
            //sold.HealtChangedEvent += ShowMessage;

            //Archer arc = new Archer("Anton");
            //arc.HealtChangedEvent += ShowMessage;

            //Peasant peas = new Peasant("Sasha");
            //peas.HealtChangedEvent += ShowMessage;

            //Bishop bishop = new Bishop("Anna", 20);
            //bishop.HealtChangedEvent += ShowMessage;

            //Building building = new Building("Build", 80);
            //building.HealtChangedEvent += ShowMessage;

            //Catapult cat = new Catapult();

            //Battle bat = new Battle();
            //bat.Fighting(sold, arc);

            //bat.Fighting(building, cat);
            //bishop.Heal(sold);

        }

        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
