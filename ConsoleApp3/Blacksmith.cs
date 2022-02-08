using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
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
