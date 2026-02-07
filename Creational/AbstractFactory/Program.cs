using Creational.AbstractFactory;

var operatingSystem = "windows";

var guiFactoryInstance = AbstractGuiFactory.Get(operatingSystem);

guiFactoryInstance.Get(GuiElementType.Button).Render();
guiFactoryInstance.Get(GuiElementType.Checkbox).Render();