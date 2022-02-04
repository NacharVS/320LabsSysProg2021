using System;
using System.Collections.Generic;
using System.Text;
using UnitInterfaces;

namespace Core
{
    public class Bishop : Unit,IMovingUnit
    {
        public Bishop(string name, double healCount)
        {
            HealCount = healCount;
        }

        public double _healCount;

        public double HealCount
        {
            get { return _healCount; }
            set { _healCount = value; }
            
        }

        public double WalkingSpeed => 3;

        public string Name { get => name; set => name = value; }
        public double Health { get => health; set => health = value; }
        public double MaxHealth { get => maxHealth; set => maxHealth = value; }

        public void Heal(IUnit unit)
        {
            if (unit.Health + HealCount >= unit.MaxHealth)
            {
                unit.Health = unit.MaxHealth;
            }
            else
            {
                unit.Health += HealCount;
            }
            
        }

        public void Message()
        {
            throw new NotImplementedException();
        }
    }
}
