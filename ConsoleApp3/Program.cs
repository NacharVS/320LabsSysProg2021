using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("Вася");
            Warrior war1 = new Warrior("Серёга");
            Peasant peas = new Peasant();
            Bishop bish = new Bishop();

            


            Battle battle = new Battle();
            Archer archer = new Archer("Igor");
            Warrior warrior = new Warrior("Iking");
            Catapult catapult = new Catapult("Angel");
            Building building = new Building("Taverna", 80);

            war.HealthChandgedEvent += ShowMessage;
            war1.HealthChandgedEvent += ShowMessage;
            building.HealthChandgedEvent += ShowMessage;
            catapult.HealthChandgedEvent += ShowMessage;


            battle.Fight(building, catapult);
            Console.WriteLine();
            battle.Fight(war, war1);

        }
        static void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }

    }
}
