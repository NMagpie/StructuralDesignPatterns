namespace _16._Structural_Design_Patterns.Formatting.ConcreteDecorators
{
    public class ColorFormattingDecorator : BaseFormatDecorator
    {
        protected string _color;

        public ColorFormattingDecorator(IFormatting wrappee, string color) : base(wrappee)
        {
            _color = color;
        }

        public override string FormatText()
        {
            return $"{_wrappee.FormatText()} with {this._color} color formatting";
        }
    }
}
