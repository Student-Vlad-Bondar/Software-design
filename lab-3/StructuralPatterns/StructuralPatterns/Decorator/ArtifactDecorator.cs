using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class ArtifactDecorator : HeroDecorator
    {
        private readonly string _artifact;
        public ArtifactDecorator(Hero hero, string artifact) : base(hero)
        {
            _artifact = artifact;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Artifact: {_artifact}";
        }
    }   
}
