namespace Structural.Bridge
{
    internal abstract class Shape
    {
        protected readonly IRenderer _renderer;
        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}
