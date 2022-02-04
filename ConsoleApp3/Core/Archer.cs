//using ConsoleApp3.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp3
//{

//    class Archer : Unit, IMovableUnit, IBattleUnit
//    {
//        public int ArrowValue;
//        public double WalkingSpeed { get; set; }
//        public double damage { get ; set ; }
//        public bool CanRangeAttack { get ; set ; }
//        public double MaxRangeAttack { get ; set ; }
//        public double AttackSpeed { get ; set ; }

//        public Archer(string name) : base(name, 300)
//        {
//            ArrowValue = 5;
//            WalkingSpeed = 1;
//            damage = 13;
//            CanRangeAttack = true;
//            MaxRangeAttack = 50;
//            AttackSpeed = 5;
//        }

        

//        //public Archer(string name) : base(name, 300, 13, 1, 5, true , 50)
//        //{
//        //    ArrowValue = 5;
//        //}

//        public void AttackUnit(IBattleUnit defender, double distance)
//        {
//            if(ArrowValue > 0)
//            {
//                if(distance <= MaxRangeAttack)
//                {
//                    rangeAttack(defender);
//                }
                
//            }
//            else
//            {
//                if(distance <= 1)
//                {
//                    (defender.GetType) defender.Health -= (new Random()).Next((int)(damage * 0.8), (int)(damage * 1.2));
//                }
//            }
            
//        }

//        void rangeAttack(IBattleUnit defender)
//        {
//            ArrowValue -= 1;
//            defender.Health -= (new Random()).Next((int)(damage * 0.8), (int)(damage * 1.2)) * 1.5;
//            if (ArrowValue == 0)
//            {
//                CanRangeAttack = false;
//            }
//        }

//    }

//}
