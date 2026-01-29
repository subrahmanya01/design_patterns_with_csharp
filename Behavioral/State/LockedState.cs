namespace Behavioural.State
{
    internal class LockedState : State
    {
        public LockedState(Phone phone) : base(phone)
        {
            
        }

        public override void OnHome()
        {
            _phone.SetState(new OnState(_phone));
            Console.WriteLine("Phone Turned On");
        }

        public override void OnOffOn()
        {
            _phone.SetState(new OnState(_phone));
            Console.WriteLine("Phone Turned On");
        }
    }
}
