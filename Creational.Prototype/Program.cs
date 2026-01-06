using Creational.Prototype;

var shapeRegistry = new ShapeRegistry();

var circle1 = new Circle(1);
var circle2 = new Circle(2);
var rectangle1 = new Rectangle(1);
var rectangle2 = new Rectangle(2);

shapeRegistry.Add("circle1", circle1);
shapeRegistry.Add("circle2", circle2);

shapeRegistry.Add("rectangle1", rectangle1);
shapeRegistry.Add("rectangle2", rectangle2);



var cloneObject = shapeRegistry.Get("rectangle1");

Console.WriteLine("Id of the cloned object is " + cloneObject.GetId());