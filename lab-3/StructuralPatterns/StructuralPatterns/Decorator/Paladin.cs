using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Paladin : Hero
    {
        public Paladin(string name)
        {
            Name = name;
            HeroType = "Paladin";
        }
    }
}
