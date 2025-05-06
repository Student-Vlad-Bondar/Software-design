using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.State
{
    public class RemovedState : INodeState
    {
        public string Name => "Removed";
        public void Handle(LightElementNode node)
        {
            Console.WriteLine($"{node.TagName} is removed from DOM");
        }
    }
}
