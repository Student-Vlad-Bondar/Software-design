using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero _hero;
        public HeroDecorator(Hero hero)
        {
            _hero = hero;
        }
        public override string GetInfo()
        {
            return _hero.GetInfo();
        }
    }
}
