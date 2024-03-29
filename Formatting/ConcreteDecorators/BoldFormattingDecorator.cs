namespace _16._Structural_Design_Patterns.Formatting.ConcreteDecorators
{
    public class BoldFormattingDecorator : BaseFormatDecorator
    {
        public BoldFormattingDecorator(IFormatting wrappee) : base(wrappee)
        {
        }

        public override string FormatText()
        {
            return $"{_wrappee.FormatText()} with bold formatting";
        }
    }
}
