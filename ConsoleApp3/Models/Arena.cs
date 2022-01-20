using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp3.Services.Logic;

namespace ConsoleApp3.Models
{
    internal class Arena
    {
        internal void StartFighting(Catapult catapult, Building building)
        { 
            catapult.GetDamageEvent += ShowMessage;
            building.GetDamageEvent += ShowMessage;
            while (building.Wall > 0 && building.Health > 0)
            {
                catapult.AttackBuilding(building);
                Console.WriteLine($"Wall: {building.Wall} Health: {building.Health}");           
            }
        }

        internal void StartFighting(Character character1, Character character2)
        {
            character1.GetDamageEvent += ShowMessage;
            character2.GetDamageEvent += ShowMessage;
            while(character1.Health > 0 && character2.Health > 0)
            {
                
                character1.Attack(character2);
                character2.Attack(character1);
                Console.WriteLine($" First unit has {character1.Health} HP, Second unit has {character2.Health} HP");
            }
            if (character1.Health > 0)
                Console.WriteLine("First character has won");
            else if (character2.Health > 0)
                Console.WriteLine("Second character has won");
            else
                Console.WriteLine("Friendship?");
        }
    }
}
