using _16._Structural_Design_Patterns.Formatting.ConcreteDecorators;

var textDecorator = new FormattingDecorator("Hello, world!");

var boldDecorator = new BoldFormattingDecorator(textDecorator);

var colorDecorator = new ColorFormattingDecorator(boldDecorator, "yellow");

Console.WriteLine(colorDecorator.FormatText());

colorDecorator.RemoveChild(boldDecorator);

// or

//colorDecorator.RemoveChild(new BoldFormattingDecorator(null));

Console.WriteLine(colorDecorator.FormatText());