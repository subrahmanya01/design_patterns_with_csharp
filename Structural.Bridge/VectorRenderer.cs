namespace Structural.Bridge
{
    internal class VectorRenderer : IRenderer
    {
        public void DrawCircle(double radius)
        {
            Console.WriteLine($"Drawing circle with vector renderer, radius {radius}");
        }

        public void DrawRectangle(double height, double width)
        {
            Console.WriteLine($"Drawing rectangle with vector renderer, height {height} width {width}");
        }
    }
}
