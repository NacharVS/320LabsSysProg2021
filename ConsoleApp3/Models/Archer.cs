using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    internal class Archer : Character
    {
        private int _countOfArows;

        public int CountOfArows 
        { 
            get => _countOfArows; 
            set
            {
                if (value > 0)
                {
                    _countOfArows = value;
                    GetDamageEvent?.Invoke($"Count of arrows: {_countOfArows}");
                }
                else
                {
                    _countOfArows = 0;

                    GetDamageEvent?.Invoke("Archer has no arrows");
                }  
            }  
        }

        internal Archer()
        {
            MaxHealth = 750;
            CountOfArows = 5;
            Health = 750;
            AttackRange = 100;
            Damage = 50;
            WalkSpeed = 100;
        }

        public override void Attack(Character character)
        {
            if (CountOfArows > 0)
            {
                AttackRange = 100;
                character.Health -= Damage;
                CountOfArows--;
            }
            else
            {
                AttackRange = 1;
                character.Health -= Damage;
            }
        }

        internal override event GetDamageDelegate GetDamageEvent;
    }
}
