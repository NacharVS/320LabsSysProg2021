using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3.Models
{
    internal abstract class Character : Unit, IAction
    {
        private double _damage;
        public double Damage { get => _damage; set => _damage = value; }

        private double _attackRange;
        public double AttackRange { get => _attackRange; set => _attackRange = value; }

        private double _walkSpeed;
        public double WalkSpeed { get => _walkSpeed; set => _walkSpeed = value; }

        public virtual void Attack(Character character)
        {
            character.Health -= Damage;
        }

        public void Move()
        {
        }
    }
}
