namespace Behavioural.State
{
    internal class Phone
    {
        private State _state;

        public Phone()
        {
            _state = new LockedState(this);
        }

        public void SetState(State state)
        {
            _state = state;
        }

        public void ClickOnHomeButton()
        {
            _state.OnOffOn();
        }

        public void ClickOnPowerButton()
        {
            _state.OnHome();
        }
    }
}
