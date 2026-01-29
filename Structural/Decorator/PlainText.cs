namespace Structural.Decorator
{
    internal class PlainText : IText
    {
        private string _text;

        public PlainText(string text)
        {
            _text = text;
        }

        public void Render()
        {
            Console.WriteLine(_text);
        }
    }
}
