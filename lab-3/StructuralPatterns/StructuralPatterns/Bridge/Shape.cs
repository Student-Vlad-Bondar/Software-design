using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        protected string name;

        public Shape(IRenderer renderer, string name)
        {
            this.renderer = renderer;
            this.name = name;
        }

        public abstract void Draw();
    }
}
