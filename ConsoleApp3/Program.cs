using System;
using CoreLibrary;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldier = new Soldier("Petya");
            var archer = new Archer("Li");

            Battle.Fight(archer, soldier, 1);
        }
    }
}
