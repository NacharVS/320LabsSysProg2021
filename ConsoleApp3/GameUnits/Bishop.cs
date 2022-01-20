namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }
        public Bishop(string name) : base(name)
        {
            HealAmount = 5;
        }
        public double Heal()
        {
            return HealAmount;
        }

        public override double GetDamage()
        {
            return Damage;
        }
    }
}
