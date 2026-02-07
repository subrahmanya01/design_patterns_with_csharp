namespace Creational.AbstractFactory.Windows
{
    internal class Button : IGuiElement
    {
        public void Render()
        {
            Console.WriteLine("Rendering Button on Windows");
        }
    }
}
