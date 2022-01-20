using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Peasant : WalkingUnit
    {
        public Peasant(string name, double health, double walkingSpeed) : base(name, health, walkingSpeed) { }
    }
}
