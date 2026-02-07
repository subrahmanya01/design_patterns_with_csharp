namespace Creational.AbstractFactory.Mac
{
    internal class MacGuiFactory : IGuiFactory
    {
        public MacGuiFactory() { }

        public IGuiElement Get(GuiElementType type)
        {
            switch (type)
            {
                case GuiElementType.Button: return new Button();
                case GuiElementType.Checkbox: return new Checkbox();
                default: throw new ArgumentException("Implementation not found for given type of Gui Element");
            }
        }
    }
}
