using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer
{
    public class ObservableLightElementNode
    {
        public string TagName { get; private set; }
        public List<ObservableLightElementNode> Children { get; set; } = new List<ObservableLightElementNode>();
        public List<string> CssClasses { get; set; } = new List<string>();
        public bool SelfClosing { get; set; } = false;

        private readonly Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();

        public ObservableLightElementNode(string tagName, bool selfClosing = false)
        {
            TagName = tagName;
            SelfClosing = selfClosing;
        }

        public string OuterHTML()
        {
            var inner = InnerHTML();
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            if (SelfClosing)
                return $"<{TagName}{classes} />";
            else
                return $"<{TagName}{classes}>{inner}</{TagName}>";
        }

        public string InnerHTML()
        {
            string result = "";
            foreach (var child in Children)
            {
                result += child.OuterHTML();
            }
            return result;
        }

        public void AddEventListener(string eventType, Action callback)
        {
            if (!_eventListeners.ContainsKey(eventType))
                _eventListeners[eventType] = new List<Action>();
            _eventListeners[eventType].Add(callback);
        }

        public void DispatchEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                Console.WriteLine($"Подія '{eventType}' викликана для тегу <{TagName}>");
                foreach (var callback in _eventListeners[eventType])
                    callback?.Invoke();
            }
        }
    }
}
