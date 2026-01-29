namespace Creational.Prototype
{
    internal abstract class Shape
    {
        protected int _id;

        public Shape(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public abstract Shape Clone();
    }
}
