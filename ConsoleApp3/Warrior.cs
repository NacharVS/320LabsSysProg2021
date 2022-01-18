using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Warrior : Unit
    {
        private int _atack;
        public int Atack
        { 
            get { return _atack; }
            set { _atack = value; }
        }

        public delegate void HealthChangerDelegate(string message);
        public event HealthChangerDelegate HealthChanerEvent;

        public Warrior()
        {
            Atack = 20;
        }

        public void Damage (Unit unit)
        {
            if (unit.Health - _atack > 0)
                unit.Health -= _atack;
            else
                unit.Health = 0;
            HealthChanerEvent?.Invoke("Был нанесен урон: " + _atack + "\n" + "Осталось здоровья: " + unit.Health);
        }
    }
}
