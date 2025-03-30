using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructuralPatterns.Bridge
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer, "Triangle") { }

        public override void Draw()
        {
            renderer.Render(name);
        }
    }
}
