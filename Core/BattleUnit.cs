using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class BattleUnit
    {
        internal string attackSpeed;
        internal double damage;
        //{
        //    private double attackSpeed;
        //    public double AttackSpeed
        //    {
        //        get { return attackSpeed; }
        //        set { attackSpeed = value; }
        //    }

        //    private double _damage;
        //    public double Damage
        //    {
        //        get { return _damage; }
        //        set { _damage = value; }
        //    }

        //    public BattleUnit(string name, double health, double walkingSpeed, double damage, double attackSpeed):base(name,health,walkingSpeed)
        //    {
        //        Damage = damage;
        //        this.attackSpeed = attackSpeed;
        //    }

        //    public virtual double MeleeAttack()
        //    {
        //        double presentDamage = Convert.ToDouble(new Random().Next(1, 40));
        //        return presentDamage;
        //    }

        //    public void Attack(BattleUnit unit, double damage)
        //    {
        //        unit.Health -= damage;
        //    }

        //    public override void Message()
        //    {
        //        Console.WriteLine($"Name: {Name}, health: {Health}, damage: {Damage}, attack speed: {attackSpeed}");
        //    }
    }
}
