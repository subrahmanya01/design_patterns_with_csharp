namespace Behavioural.Command
{
    internal class TurnOffCommand : ICommand
    {
        private readonly RemoteBulb _remoteBulb;
        public TurnOffCommand(RemoteBulb remoteBulb)
        {
            _remoteBulb = remoteBulb;
        }

        public void Execute()
        {
            _remoteBulb.TurnOff();
        }

        public void Redo()
        {
            _remoteBulb.TurnOn();
        }

        public void Undo()
        {
            Execute();
        }
    }
}
