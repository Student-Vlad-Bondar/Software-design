﻿using StructuralPatterns.BehavioralPatterns.State;
using StructuralPatterns.BehavioralPatterns.Visitor;
using System.Text;

namespace StructuralPatterns.Composite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public List<string> CssClasses { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        public INodeState State { get; private set; } = new CreatedState();
        public bool SelfClosing { get; set; } = false;

        public LightElementNode(string tagName, bool selfClosing = false)
        {
            TagName = tagName;
            SelfClosing = selfClosing;
            State.Handle(this);
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<{TagName}");
            if (CssClasses.Any())
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
            if (SelfClosing)
            {
                sb.Append(" />");
            }
            else
            {
                sb.Append(">");
                sb.Append(InnerHTML());
                sb.Append($"</{TagName}>");
            }
            return sb.ToString();
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML());
            }
            return sb.ToString();
        }

        public void TransitionTo(INodeState newState)
        {
            State = newState;
            State.Handle(this);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var c in Children)
                c.Accept(visitor);
        }
    }
}
