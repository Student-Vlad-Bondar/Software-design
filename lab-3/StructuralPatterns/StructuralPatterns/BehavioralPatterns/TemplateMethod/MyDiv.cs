namespace StructuralPatterns.BehavioralPatterns.TemplateMethod
{
    public class MyDiv : LifecycleElement
    {
        public MyDiv() : base("div")
        {
            CssClasses.Add("my-div");
        }

        protected override void OnCreated()
            => Console.WriteLine("<div> created!");

        protected override void OnClassListApplied()
            => Console.WriteLine("Клас(и) застосовано: " + string.Join(", ", CssClasses));

        protected override void OnStylesApplied()
            => Console.WriteLine("Стилі застосовано: " +
                (Styles.Count > 0
                    ? string.Join("; ", Styles.Select(kv => $"{kv.Key}: {kv.Value}"))
                    : "(немає)"));

        protected override void OnRendered()
            => Console.WriteLine("<div> rendered!");
    }
}
