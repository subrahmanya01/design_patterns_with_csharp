using Behavioral.Mediator.Components;

namespace Behavioral.Mediator.Mediator
{
    internal class FormMediator : IMediator
    {
        private TextBox _userName;
        private TextBox _password;

        private Button _button;

        public void SetUserName(TextBox textBox)
        {
            _userName = textBox;
        }

        public void SetPassword(TextBox textBox)
        {
            _password = textBox;
        }

        public void SetButton(Button button)
        {
            _button = button;
        }
        public void ComponentChanged(IUIComponent component)
        {
            if (component == _userName || component == _password)
            {
                if (_userName.GetTextContent().Length == 0 || _password.GetTextContent().Length == 0)
                {
                    _button.DisableButton();
                }
                else
                {
                    _button.EnableButton();
                }
            }

            if (component == _button && _button.IsButtonEnabled())
            {
                Console.WriteLine("Form submitted sucessfully");
            }
        }
    }
}
