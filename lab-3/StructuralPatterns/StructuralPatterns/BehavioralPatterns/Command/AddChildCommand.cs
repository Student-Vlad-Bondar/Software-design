using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Command
{
    public class AddChildCommand : ICommand
    {
        private readonly LightElementNode _parent;
        private readonly LightNode _child;

        public AddChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            _parent.Children.Add(_child);
        }

        public void Undo()
        {
            _parent.Children.Remove(_child);
        }
    }
}
