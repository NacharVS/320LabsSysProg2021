
namespace ConsoleApp3
{
    class WalkingUnits : Unit
    {
        private double _speed;

        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public WalkingUnits(string name) : base(name)
        {

        }

    }
}
