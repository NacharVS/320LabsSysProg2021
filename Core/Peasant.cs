using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Peasant : IMovingUnit
    {
        public double WalkingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Peasant(string name)/*: base(name,90,2)*/
        {

        }
    }
}
