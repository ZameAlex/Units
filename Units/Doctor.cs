using System;
using System.Collections.Generic;
using System.Text;

namespace Units
{
    public class Doctor : Unit
    {
        public Doctor(int hp, string name, int attack, int speed) : base(hp, name, attack, speed)
        {
        }

        protected override void Death()
        {

        }

        public override void Skill(Unit target)
        {
            target.ModifyHP(_attack);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Attack {_attack}";
        }
    }
}
