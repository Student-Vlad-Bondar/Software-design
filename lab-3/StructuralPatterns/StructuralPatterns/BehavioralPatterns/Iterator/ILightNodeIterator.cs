using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Iterator
{
    public interface ILightNodeIterator
    {
        bool HasNext();
        LightNode Next();
    }
}
