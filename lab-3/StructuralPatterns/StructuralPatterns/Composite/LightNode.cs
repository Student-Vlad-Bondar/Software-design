using StructuralPatterns.BehavioralPatterns.Visitor;

namespace StructuralPatterns.Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();
        public abstract void Accept(IVisitor visitor);
    }
}
