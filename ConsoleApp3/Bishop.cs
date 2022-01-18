namespace ConsoleApp3
{
    class Bishop : Unit
    {
        public double HealAmount { get; set; }
        public Bishop()
        {
            HealAmount = 5;
        }
        public double Heal()
        {
            return HealAmount;
        }
    }
}
