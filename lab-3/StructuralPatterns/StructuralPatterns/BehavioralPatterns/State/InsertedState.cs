using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.State
{
    public class InsertedState : INodeState
    {
        public string Name => "Inserted";
        public void Handle(LightElementNode node)
        {
            Console.WriteLine($"{node.TagName} is inserted into DOM");
        }
    }
}
