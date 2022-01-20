using System;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Unit
    {
        public delegate void HealthChangedDelegate(string message);
        public event HealthChangedDelegate HealthChangedEvent; 
        public string Name { get; protected set; }
        public string TypeOfClass { get; protected set; }
        public double MaxHealth { get; private set; }
        public double Health { get; private set; }
        public double MleeDamage { get; protected set; }
        public int MleeAttackSpeed { get; protected set; } //in milliseconds
        public int WalkingSpeed { get; protected set; } //cells per second

        public Unit() { }
        public Unit(string type, string name, double health)
        {
            TypeOfClass = type;
            MaxHealth = health;
            Health = MaxHealth;
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

        public void MleeAttack()
        {
            Task.Delay(MleeAttackSpeed);
        }
    }
}
