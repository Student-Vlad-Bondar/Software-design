using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Visitor
{
    public class TextCountVisitor : IVisitor
    {
        public int Count { get; private set; }

        public void Visit(LightElementNode element) { /* нічого */ }

        public void Visit(LightTextNode text)
            => Count++;
    }
}
