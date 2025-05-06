using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(LightElementNode element);
        void Visit(LightTextNode text);
    }
}
