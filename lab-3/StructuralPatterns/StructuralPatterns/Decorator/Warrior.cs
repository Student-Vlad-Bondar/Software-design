using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Warrior : Hero
    {
        public Warrior(string name)
        {
            Name = name;
            HeroType = "Warrior";
        }
    }
}
