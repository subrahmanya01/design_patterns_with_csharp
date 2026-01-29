namespace Behavioural.Command
{
    internal class TurnOnCommand : ICommand
    {
        private readonly RemoteBulb _remoteBulb;
        public TurnOnCommand(RemoteBulb remoteBulb)
        {
            _remoteBulb = remoteBulb;
        }

        public void Execute()
        {
            _remoteBulb.TurnOn();
        }

        public void Redo()
        {
            _remoteBulb.TurnOff();
        }

        public void Undo()
        {
            Execute();
        }
    }
}
