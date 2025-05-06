using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Command
{
    public class RemoveChildCommand : ICommand
    {
        private readonly LightElementNode _parent;
        private readonly LightNode _child;

        public RemoveChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            _parent.Children.Remove(_child);
        }

        public void Undo()
        {
            _parent.Children.Add(_child);
        }
    }
}
