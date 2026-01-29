namespace Structural.Bridge
{
    internal class Circle : Shape
    {
        private readonly double _radius;
        public Circle(IRenderer renderer, double radius): base(renderer)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            _renderer.DrawCircle(_radius);
        }
    }
}
