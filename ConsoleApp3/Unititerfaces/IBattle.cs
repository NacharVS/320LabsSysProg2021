using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Unititerfaces
{
    public interface IBattle:IUnit
    {
        double AttackSpeed { get; set; }
        double Damage { get; set; }
        double MeleeAttack();
        void Attack(IBattle battle, double damage); 
    }
}
