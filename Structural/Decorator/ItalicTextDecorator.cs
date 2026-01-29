namespace Structural.Decorator
{
    internal class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(IText text): base(text)
        {
            
        }
        public override void Render()
        {
            Console.WriteLine("<i>");
            _text.Render();
            Console.WriteLine("</i>");
        }
    }
}
