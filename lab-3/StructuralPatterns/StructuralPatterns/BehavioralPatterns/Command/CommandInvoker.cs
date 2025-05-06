namespace StructuralPatterns.BehavioralPatterns.Command
{
    public class CommandInvoker
    {
        private readonly Stack<ICommand> _history = new Stack<ICommand>();
        private readonly Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
            _redoStack.Clear();
        }

        public void UndoLast()
        {
            if (_history.Count == 0) return;
            var cmd = _history.Pop();
            cmd.Undo();
            _redoStack.Push(cmd);
        }

        public void RedoLast()
        {
            if (_redoStack.Count == 0) return;
            var cmd = _redoStack.Pop();
            cmd.Execute();
            _history.Push(cmd);
        }
    }
}
