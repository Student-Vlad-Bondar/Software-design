using StructuralPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    public class LightHTMLFactory
    {
        // Кешуємо шаблон елемента за тегом та прапорцем selfClosing
        private readonly Dictionary<string, LightElementNode> cache = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName, bool selfClosing = false)
        {
            string key = tagName + selfClosing.ToString();
            if (!cache.ContainsKey(key))
            {
                cache[key] = new LightElementNode(tagName, selfClosing);
            }
            // Повертаємо новий екземпляр з внутрішнім станом, збереженим у кеші
            return new LightElementNode(cache[key].TagName, cache[key].SelfClosing);
        }
    }
}
