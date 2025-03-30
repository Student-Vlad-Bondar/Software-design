using StructuralPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    public class HTMLConverter
    {
        private readonly LightHTMLFactory factory = new LightHTMLFactory();

        public LightElementNode ConvertTextToHTML(List<string> lines)
        {
            var container = new LightElementNode("div");

            bool isFirstLine = true;
            string previousLine = null;
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (previousLine != null && line.Trim() == previousLine.Trim())
                    continue;
                previousLine = line;

                LightElementNode element = null;
                if (isFirstLine)
                {
                    element = factory.GetElement("h1");
                    isFirstLine = false;
                }
                else if (line.StartsWith(" "))
                {
                    element = factory.GetElement("blockquote");
                }
                else if (line.Length < 20)
                {
                    element = factory.GetElement("h2");
                }
                else
                {
                    element = factory.GetElement("p");
                }
                element.Children = new List<LightNode> { new LightTextNode(line) };
                container.Children.Add(element);
            }
            return container;
        }
    }
}
