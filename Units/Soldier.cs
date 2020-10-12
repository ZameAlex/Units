using System;
using System.Collections.Generic;
using System.Text;

namespace Units
{
    public class Soldier : Unit
    {
        public Soldier(int hp, string name, int attack, int speed) : base(hp, name, attack, speed)
        {

        }

        protected override void Death()
        {
        }


        public override void Skill(Unit target = default)
        {
            _speed = 0;
            Upgrade(_attack);
        }
    }
}
