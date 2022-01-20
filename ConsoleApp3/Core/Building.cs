using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Core
{
    class Building : Unit
    {
        private double _wall;

        public double Wall
        {
            get { return _wall; }
            set { _wall = value; }
        }


        public Building(string name) : base(name)
        {

        }
    }
}
