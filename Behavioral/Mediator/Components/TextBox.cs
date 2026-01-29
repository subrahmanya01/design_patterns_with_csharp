using Behavioral.Mediator.Mediator;

namespace Behavioral.Mediator.Components
{
    internal class TextBox : UIComponent
    {
        private string _textContent = string.Empty;
        public TextBox(IMediator mediator) : base(mediator)
        {
        }

        public string GetTextContent()
        {
            return _textContent;
        }

        public void SetTextContent(string text)
        {
            _textContent = text;
            NotifyMediator();
        }
    }
}
