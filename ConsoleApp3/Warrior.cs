namespace ConsoleApp3
{
    class Warrior : Unit
    {
        public override double MaxHealth => 100;
        public Warrior()
        {
            Health = 100;
            Attack = 10;
        }
    }
}
