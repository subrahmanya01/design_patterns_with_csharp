namespace Structural.Decorator
{
    internal class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(IText text): base(text)
        {
            
        }
        public override void Render()
        {
            Console.WriteLine("<b>");
            _text.Render();
            Console.WriteLine("</b>");
        }
    }
}
