namespace Behavioural.State
{
    internal class OnState : State
    {
        public OnState(Phone phone) : base(phone)
        {
            
        }
        public override void OnHome()
        {
            _phone.SetState(new OnHomeState(_phone));
            Console.WriteLine("Phone unlocked and moving to home screen");
        }

        public override void OnOffOn()
        {
            _phone.SetState(new LockedState(_phone));
            Console.WriteLine("Turning off the screen");
        }
    }
}
