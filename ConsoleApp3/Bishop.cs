using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Bishop : Unit, IUnit, IHealUnit
    {

        public double Healmount => 30;


        public Bishop()
        {
            name = "Bishop";
            Health = 80;
        }

        public void DoHeal(IUnit unit)
        {
            unit.Health += Healmount;
            
        }

    }
}
