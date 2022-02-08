using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Soldier
    {
        public int Health { get; set; }
        public IWeapon weapon { get; set; }

        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Throw(IThrowableWeapon weapon)
        {
            weapon.Throw();
        }
        public void Walk()
        {

        }
    }
}
