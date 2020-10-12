using System;
using System.Collections.Generic;
using System.Text;

namespace Units
{
    public class FireSoldier : Unit
    {
        public List<Unit> _surrounded;
        public FireSoldier(int hp, string name, int attack, int speed, List<Unit> surrounded) : base(hp, name, attack, speed)
        {
            _surrounded = surrounded;
        }

        protected override void Death()
        {
            foreach (var unit in _surrounded)
            {
                Attack(unit);
            }
        }

        public override void Skill(Unit target = default)
        {
            Attack(target);
            Attack(target);
        }
    }
}
