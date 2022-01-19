﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Archer : Character
    {
        private int _countOfArows;

        public int CountOfArows { get => _countOfArows; set => _countOfArows = value; }

        internal Archer()
        {
            CountOfArows = 5;
            Health = 750;
            AttackRange = 100;
            Damage = 50;
            WalkSpeed = 100;
        }
    }
}