using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Mage : Hero
    {
        public Mage(string name)
        {
            Name = name;
            HeroType = "Mage";
        }
    }
}
