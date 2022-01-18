namespace ConsoleApp3
{
    abstract class Unit
    {
        public delegate void HealhtChangeDelegate(string health);
        private double _health;
        public event HealhtChangeDelegate HealthChangeEvent;
        public double Health
        {
            get { return _health; }
            set
            {
                if (value > 0)
                {
                    _health = value;
                    HealthChangeEvent?.Invoke($"Current health {_health}");
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
