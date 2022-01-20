using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Peasant : MovableUnit
    {
        public Peasant(string name, double health, double walkingSpeed) : base(name, health, walkingSpeed) { }
    }
}
