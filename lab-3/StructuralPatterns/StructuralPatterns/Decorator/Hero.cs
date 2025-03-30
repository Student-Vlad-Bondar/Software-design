using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public string HeroType { get; set; }
        public virtual string GetInfo()
        {
            return $"Name: {Name}, Type: {HeroType}";
        }
    }
}
