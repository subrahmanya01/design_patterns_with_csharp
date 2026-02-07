namespace Creational.AbstractFactory
{
    internal interface IGuiFactory
    {
        IGuiElement Get(GuiElementType type);
    }
}
