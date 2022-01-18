using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public delegate void InflictDamageDelegate(Peasant peasant, int damage);
        public void InflictDamageToPeasant(Peasant peasant, int damage)
        {
            peasant.Health -= damage;
            InflictDamageEvent?.Invoke(peasant, damage);
        }
        public event InflictDamageDelegate InflictDamageEvent;
    }
}
