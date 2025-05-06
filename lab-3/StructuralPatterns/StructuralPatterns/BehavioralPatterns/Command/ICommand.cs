namespace StructuralPatterns.BehavioralPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
