namespace Creational.AbstractFactory.Mac
{
    internal class Button : IGuiElement
    {
        public void Render()
        {
            Console.WriteLine("Rendering Button on Mac");
        }
    }
}
