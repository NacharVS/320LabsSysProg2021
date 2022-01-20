using System;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class RangeUnit : Unit
    {
        public double RangeDamage { get; protected set; }
        public double RangeAttackDistance { get; protected set; }
        public int RangeProjectileCount { get; protected set; }
        public int RangeAttackSpeed { get; protected set; } //in milliseconds
        public RangeUnit(string type, string name, double health) : base(type, name, health) { }
        
        public void RangeAttack()
        {
            RangeProjectileCount--;
            Task.Delay(RangeAttackSpeed);
        }
    }
}
