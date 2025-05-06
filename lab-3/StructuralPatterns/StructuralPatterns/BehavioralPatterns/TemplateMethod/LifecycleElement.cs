using StructuralPatterns.Composite;

namespace StructuralPatterns.BehavioralPatterns.TemplateMethod
{
    public abstract class LifecycleElement : LightElementNode
    {
        protected LifecycleElement(string tagName, bool selfClosing = false)
            : base(tagName, selfClosing)
        {
            Styles = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Styles { get; }

        // Шаблонний метод
        public string Render()
        {
            OnCreated();
            OnClassListApplied();
            OnStylesApplied();
            var html = OuterHTML();
            OnRendered();
            return html;
        }

        protected virtual void OnCreated() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnRendered() { }
    }
}
