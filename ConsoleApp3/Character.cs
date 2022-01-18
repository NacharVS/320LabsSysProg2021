using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Character
    {
        public delegate void HealthChangedDelegate(string message);
        public event HealthChangedDelegate HealthChangedEvent; 
        public double MaxHealth { get; set; }
        public double Health { get; set; }
        public double Attack { get; set; }

        public Character() { }
        public Character(double health, double attack)
        {
            MaxHealth = health;
            Health = MaxHealth;
            Attack = attack;
        }

        public void Heal(double health)
        {
            Health += health;
            double healing = health;
            if (Health > MaxHealth)
            {
                healing -= Health - MaxHealth;
                Health = MaxHealth;
            }
            HealthChangedEvent?.Invoke($"Получено лечение: {healing}\t" +
                                       $"Текущее HP: { Health}");
        }
        public void Damage(double health)
        {
            Health -= health;
            double damage = health;
            if (Health < 0)
            {
                damage += Health;
                Health = 0;
            }
            HealthChangedEvent?.Invoke($"Получен урон: {damage}\t" +
                                       $"Текущее HP: {Health}");
        }
    }
}
