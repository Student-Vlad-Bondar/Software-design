using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Visitor
{
    public class StatsVisitor : IVisitor
    {
        public int ElementCount { get; private set; } = 0;
        public int TextCount { get; private set; } = 0;
        public Dictionary<string, int> TagCounts { get; } = new Dictionary<string, int>();

        public void Visit(LightElementNode element)
        {
            ElementCount++;

            if (TagCounts.ContainsKey(element.TagName))
                TagCounts[element.TagName]++;
            else
                TagCounts[element.TagName] = 1;
        }

        public void Visit(LightTextNode text)
        {
            TextCount++;
        }

        public void PrintStatistics()
        {
            Console.WriteLine($"Total elements: {ElementCount}");
            Console.WriteLine($"Total text nodes: {TextCount}");
            Console.WriteLine("Elements by tag:");
            foreach (var kvp in TagCounts)
                Console.WriteLine($"  <{kvp.Key}>: {kvp.Value}");
        }
    }
}
