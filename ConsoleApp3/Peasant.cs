namespace ConsoleApp3
{
    class Peasant : Unit
    {
        public override double MaxHealth => 100;
        public Peasant()
        {
            Health = 100;
            Attack = 1;
        }
    }
}
