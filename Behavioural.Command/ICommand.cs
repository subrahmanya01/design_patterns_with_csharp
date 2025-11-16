namespace Behavioural.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
