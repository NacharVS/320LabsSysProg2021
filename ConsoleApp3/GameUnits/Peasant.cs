namespace ConsoleApp3
{
    class Peasant : Unit
    {
        public override double MaxHealth => 100;
        public Peasant(string name) : base(name)
        {
            Health = 100;
            Damage = 1;
        }

        public override double GetDamage()
        {
            return Damage;
        }
    }
}
