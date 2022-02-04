using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    internal interface IMovableUnit
    {
        int WalkSpeed { get; }
        void Move();
    }
}
