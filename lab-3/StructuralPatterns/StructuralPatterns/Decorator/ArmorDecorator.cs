using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class ArmorDecorator : HeroDecorator
    {
        private readonly string _armor;
        public ArmorDecorator(Hero hero, string armor) : base(hero)
        {
            _armor = armor;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Armor: {_armor}";
        }
    }
}
