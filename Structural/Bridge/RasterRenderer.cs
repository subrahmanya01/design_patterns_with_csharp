namespace Structural.Bridge
{
    internal class RasterRenderern : IRenderer
    {
        public void DrawCircle(double radius)
        {
            Console.WriteLine($"Drawing cirlce with raster renderer : radius :{radius}");
        }

        public void DrawRectangle(double height, double width)
        {
            Console.WriteLine($"Drawing rectangle with raster renderer, width {width} height {height}");
        }
    }
}
