namespace Behavioural.Command
{
    internal class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}
