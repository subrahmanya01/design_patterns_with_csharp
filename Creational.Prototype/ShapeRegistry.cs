namespace Creational.Prototype
{
    internal class ShapeRegistry
    {
        private Dictionary<string, Shape> _shapes;
        public ShapeRegistry() { 
           _shapes = new Dictionary<string, Shape>();
        }

        public void Add(string name, Shape shape) { 
          _shapes[name] = shape;
        }

        public Shape Get(string name) {
            if (_shapes.ContainsKey(name)) { 
               return _shapes[name].Clone();
            }
            throw new ArgumentException("No prototype available with given key", name);
        }
    }
}
