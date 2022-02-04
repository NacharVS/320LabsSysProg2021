using System;

namespace CoreLibrary
{
    public class Cleric : Unit
    {
        public double Healing { get; private set; }
        public Cleric(string name) : base("Cleric", name, 80)
        {
            MleeDamage = 3;
            Healing = 10;
        }
    }
}
