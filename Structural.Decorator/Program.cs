using Structural.Decorator;

var plainText = new PlainText("Hey");


var boldText = new BoldTextDecorator(plainText);
Console.WriteLine("Bold Text");
boldText.Render();
Console.WriteLine();

var boldItalicText = new ItalicTextDecorator(boldText);
Console.WriteLine("Bold Italic");
boldItalicText.Render();
Console.WriteLine();

var plainItalicText = new ItalicTextDecorator(plainText);
Console.WriteLine("Plain italic");
plainItalicText.Render();
Console.WriteLine();
