﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class RasterRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine("Drawing " + shapeName + " as raster graphics.");
        }
    }
}
