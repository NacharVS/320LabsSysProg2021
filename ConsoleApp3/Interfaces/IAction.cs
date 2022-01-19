using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Models;

namespace ConsoleApp3.Interfaces
{
    internal interface IAction
    {
        void Attack(Character character);
        void Move();
    }
}
