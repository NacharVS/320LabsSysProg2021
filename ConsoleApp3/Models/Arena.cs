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
            while (building.Wall > 0 || building.Health > 0)
            {
                catapult.AttackBuilding(building);
                Console.WriteLine($"Wall: {building.Wall} Health: {building.Health}");           
            }
        }
    }
}
