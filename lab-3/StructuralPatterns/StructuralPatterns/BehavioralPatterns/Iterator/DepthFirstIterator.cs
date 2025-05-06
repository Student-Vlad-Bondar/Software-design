using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Iterator
{
    public class DepthFirstIterator : ILightNodeIterator
    {
        private readonly Stack<LightNode> _stack = new Stack<LightNode>();

        public DepthFirstIterator(LightNode root)
        {
            _stack.Push(root);
        }

        public bool HasNext() => _stack.Count > 0;

        public LightNode Next()
        {
            var node = _stack.Pop();
            if (node is LightElementNode elem)
            {
                for (int i = elem.Children.Count - 1; i >= 0; i--)
                    _stack.Push(elem.Children[i]);
            }
            return node;
        }
    }
}
