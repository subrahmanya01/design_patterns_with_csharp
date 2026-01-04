namespace Behavioural.State
{
    internal abstract class State
    {
        protected Phone _phone;
        public State(Phone phone)
        {
            _phone = phone;
        }

        public abstract void OnHome();

        public abstract void OnOffOn();
    }
}
