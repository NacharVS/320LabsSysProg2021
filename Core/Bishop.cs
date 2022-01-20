using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Bishop : WalkingUnit
    {
        private double _healAmount;
    public double HealAmount
    {
        get { return _healAmount; }
        set { _healAmount = value; }
    }

    public Bishop(string name, double health, double damage, double heal) : base(name, health, damage)
    {
        HealAmount = heal;
    }

    public void Heal(Unit unit)
    {
        unit.Health += HealAmount;
    }
}
}
