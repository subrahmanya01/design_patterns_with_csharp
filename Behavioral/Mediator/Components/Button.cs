using Behavioral.Mediator.Mediator;

namespace Behavioral.Mediator.Components
{
    internal class Button : UIComponent
    {
        private bool _enabled = true;
        public Button(IMediator mediator) : base(mediator)
        {
        }

        public bool IsButtonEnabled()
        {
            return _enabled;
        }

        public void DisableButton()
        {
            _enabled = false;
        }

        public void EnableButton()
        {
            _enabled = true;
        }

        public void Click()
        {
            if (_enabled)
            {
                Console.WriteLine("Button clicked");
                NotifyMediator();
                return;
            }
            Console.WriteLine("Failed to click button, Button is disabled");
        }
    }
}
