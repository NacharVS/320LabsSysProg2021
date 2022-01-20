namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void HealhtChangeDelegate(string health);
        public virtual double MaxHealth { get; }
        public event HealhtChangeDelegate HealthChangeEvent;
        public string name;

        public Unit(string name)
        {
            this.name = name;
        }


        private double _health;
        public double Health
        {
            get { return _health; }
            set
            {
                if (value > 0 && value <= MaxHealth)
                {
                    HealthChangeEvent?.Invoke($"{name} old health value {_health}, changed {-(_health - value)}, now {_health - (_health-value)} ");
                    _health = value;
                }
                else
                {
                    _health = 0;
                    HealthChangeEvent?.Invoke($"{name} Unit died, health {_health}");
                }
            }
        }

        private double _damage;

        public double Damage
        {
            get { return _damage; }
            set
            {
                _damage = value;
            }
        }

        private double _attackSpeed;

        public double AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }

        private double _attackRange;

        public double AttackRange
        {
            get { return _attackRange; }
            set { _attackRange = value; }
        }

        public virtual double GetDamage()
        {
            return _damage;
        }


    }
}
