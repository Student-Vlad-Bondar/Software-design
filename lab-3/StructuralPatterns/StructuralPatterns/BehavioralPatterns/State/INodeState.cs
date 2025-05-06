using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.State
{
    public interface INodeState
    {
        void Handle(LightElementNode node);
        string Name { get; }
    }
}
