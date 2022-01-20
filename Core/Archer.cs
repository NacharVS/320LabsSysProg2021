using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Archer : BattleUnit
    {
        private int _arrows;
        private int _minRangeDamge;
        private int _maxRangeDamge;

        public Archer(string name) : base(name, 100, 3, 9, 2)
        {
            _arrows = 5;
            _minRangeDamge = 
        }
    }
}
