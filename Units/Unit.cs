using System;
using System.Collections.Generic;
using System.Text;

namespace Units
{
    public abstract class Unit
    {
        protected string _name;
        protected int _HP;
        private readonly int _maxHP;
        protected int _attack;
        public int _speed;

        protected Unit(int hp, string name, int attack, int speed)
        {
            _maxHP = hp;
            _HP = _maxHP;
            _name = name;
            _attack = attack;
            _speed = speed;
        }

        public void Attack(Unit target)
        {
            target.ModifyHP(_attack);
        }

        public void ModifyHP(int value)
        {
            if (value < 0)
                _HP = _HP - value > _maxHP ? _maxHP : _HP - value;
            else
            {
                _HP = _HP - value < 0 ? 0 : _HP - value;
            }
            if (_HP == 0)
                Death();
        }

        public void Upgrade(int value)
        {
            _attack += value;
        }

        protected abstract void Death();

        public abstract void Skill(Unit target = default);

        public virtual string GetInfo()
        {
            return $"Name: {_name}, HP: {_HP}";
        }
    }
}
