using Creational.AbstractFactory.Mac;
using Creational.AbstractFactory.Windows;

namespace Creational.AbstractFactory
{
    internal static class AbstractGuiFactory
    {
        public static IGuiFactory Get(string osType)
        {
            switch (osType)
            {
                case "windows": return new WindowsGuiFactory();
                case "mac": return new MacGuiFactory();
                default: throw new ArgumentException("Gui Element Implementation Not found for the given type of Operating System");
            }
        }
    }
}
