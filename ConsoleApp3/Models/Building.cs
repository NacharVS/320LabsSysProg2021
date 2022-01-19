using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal class Building : Unit, IBuilding
    {
        private double _wall;

        public double Wall
        {
            get => _wall;
            set
            {
                if(value > 0)
                {
                    _wall = value;
                    GetDamageEvent?.Invoke($"The Building's wall has {Wall} points");
                }
                else
                {
                    _wall = 0;
                    GetDamageEvent?.Invoke("The Building's wall has fallen");
                }
            }
        }

        internal Building()
        {
            Wall = 1500;
            Health = 1000;
            MaxHealth = Health;
        }

        internal override event GetDamageDelegate GetDamageEvent;
    }
}
