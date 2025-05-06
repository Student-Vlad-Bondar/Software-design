using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.State
{
    public class CreatedState : INodeState
    {
        public string Name => "Created";
        public void Handle(LightElementNode node)
        {
            Console.WriteLine($"{node.TagName} is created");
        }
    }
}
