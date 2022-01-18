namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void HealhtChangeDelegate(string health);
        private double _health;
        public virtual double MaxHealth { get; }
        public event HealhtChangeDelegate HealthChangeEvent;
        public double Health
        {
            get { return _health; }
            set
            {
                if (value > 0 && value <= MaxHealth)
                {
                    HealthChangeEvent?.Invoke($"Current health {_health}, changed {-(_health - value)}");
                    _health = value;
                }
                else
                {
                    _health = 0;
                    HealthChangeEvent?.Invoke($"Unit died, health {_health}");
                }
            }
        }

        private int _attack;

        public int Attack
        {
            get { return _attack; }
            set
            {
                _attack = value;
            }
        }


    }
}
