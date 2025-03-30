using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructuralPatterns.Bridge
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer, "Square") { }

        public override void Draw()
        {
            renderer.Render(name);
        }
    }
}
