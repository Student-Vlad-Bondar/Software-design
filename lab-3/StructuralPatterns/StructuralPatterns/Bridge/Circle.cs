using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer, "Circle") { }

        public override void Draw()
        {
            renderer.Render(name);
        }
    }
}
