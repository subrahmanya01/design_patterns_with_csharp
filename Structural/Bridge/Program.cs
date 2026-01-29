using Structural.Bridge;

var vectorRenderer = new VectorRenderer();
var rasterRenderer = new RasterRenderern();

var circle = new Circle(vectorRenderer, 1.2);
circle.Draw();

circle = new Circle(rasterRenderer, 1.2);
circle.Draw();

var rectangle = new Rectangle(rasterRenderer, 1.2, 5);
rectangle.Draw();

rectangle = new Rectangle(vectorRenderer, 1.2, 5);
rectangle.Draw();