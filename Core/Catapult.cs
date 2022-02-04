using UnitInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Catapult : IBattleUnit
    {
        public  bool isCatapult => true;

        public double AttackSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsCatapult => true;

        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string name = "Catapult";
        public string Name { get => name; set => name = value; }

        public Catapult()/* : base("Catapult", 210, 30, 4, 5)*/
        {
        }

        public double MeleeAttack()
        {
            throw new NotImplementedException();
        }

        public void Attack(IBattleUnit unit, double damage)
        {
            throw new NotImplementedException();
        }

        public void Message()
        {
            Console.WriteLine($"{Name} health: {Health}, max health: {MaxHealth}");
        }
    }
}
