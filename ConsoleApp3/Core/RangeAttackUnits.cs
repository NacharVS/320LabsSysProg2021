using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class RangeAttackUnits : WalkingUnits
    {
        public delegate void ShotsCountChangedDelegate(string mes);
        public event ShotsCountChangedDelegate ShotsCountChangeEvent;
        private int _shotsNumber;

        public int Shots
        {
            get { return _shotsNumber; }
            set { 
                _shotsNumber = value;
                ShotsCountChangeEvent?.Invoke($"Current number of shots remaining {_shotsNumber}");
                }
        }

        public RangeAttackUnits(string name) : base(name)
        {

        }

    }
}
