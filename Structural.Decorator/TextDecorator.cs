namespace Structural.Decorator
{
    internal abstract class TextDecorator : IText
    {
        protected IText _text;

        public TextDecorator(IText text)
        {
            _text = text;
        }

        public abstract void Render();
    }
}
