using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class WeaponDecorator : HeroDecorator
    {
        private readonly string _weapon;
        public WeaponDecorator(Hero hero, string weapon) : base(hero)
        {
            _weapon = weapon;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Weapon: {_weapon}";
        }
    }
}
