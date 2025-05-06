using StructuralPatterns.BehavioralPatterns.Visitor;

namespace StructuralPatterns.Composite
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string OuterHTML() => Text;
        public override string InnerHTML() => Text;
        public override void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
