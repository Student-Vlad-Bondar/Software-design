using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.Iterator
{
    public class BreadthFirstIterator : ILightNodeIterator
    {
        private readonly Queue<LightNode> _queue = new Queue<LightNode>();

        public BreadthFirstIterator(LightNode root)
        {
            _queue.Enqueue(root);
        }

        public bool HasNext() => _queue.Count > 0;

        public LightNode Next()
        {
            var node = _queue.Dequeue();
            if (node is LightElementNode elem)
            {
                foreach (var child in elem.Children)
                    _queue.Enqueue(child);
            }
            return node;
        }
    }
}
