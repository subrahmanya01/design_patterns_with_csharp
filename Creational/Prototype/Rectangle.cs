namespace Creational.Prototype
{
    internal class Rectangle : Shape
    {
        public Rectangle(int id) : base(id)
        {
        }

        public override Shape Clone()
        {
            return new Rectangle(_id);
        }
    }
}
