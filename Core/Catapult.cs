using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Catapult : BattleUnit
    {
        private double _projectiles;

        public double Projectiles
        {
            get { return _projectiles; }
            set { _projectiles = value; }
        }
        public override bool isCatapult => true;
        
        public Catapult(string name) : base(name, 200, 1, 20, 0.5)
        {
            _projectiles = 10;
        }

        public double RangeAttack()
        {
            if (Projectiles > 0)
            {
                --Projectiles;
                return MeleeAttack();
            }
            else
            {
                return 0;
            }
        }
    }
}
