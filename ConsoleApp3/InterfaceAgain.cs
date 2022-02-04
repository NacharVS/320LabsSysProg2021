using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    interface IWeapon
    {
        int damage { get; }

        void InflictDamage();
    }

    interface IRepairible
    {
        void Repair();
    }

    interface IThrowableWeapon : IWeapon
    {
        void Throw();
    }

    class Sword : IWeapon, IRepairible
    {
        public int damage => 5;

        public void InflictDamage()
        {
            Console.WriteLine($"shooooh! {damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }
    }

    class Bow : IWeapon
    {
        public int damage => 7;

        public void InflictDamage()
        {
            Console.WriteLine($"piuuuuuu {damage}");
        }
    }

    class Javelin : IRepairible, IThrowableWeapon
    {
        public int damage => 6;
        public int durability;

        public void InflictDamage()
        {
            Console.WriteLine($"tik {damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has repaired");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name} fooooooh");
        }
    }
    class InterfacesAgain
    {
    }

    class Soldie
    {
        public int Health { get; set; }
        public IWeapon weapon { get; set; }

        public Soldie(IWeapon weapon)
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

    class Blacksmith
    {
        public Sword MakeSword()
        {
            return new Sword();
        }
        public Bow MakeBow()
        {
            return new Bow();
        }
        public Javelin MakeJavelin()
        {
            return new Javelin();
        }

        public void Repair(IRepairible item)
        {
            item.Repair();
        }
    }
}
