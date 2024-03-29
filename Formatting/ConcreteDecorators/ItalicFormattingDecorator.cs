namespace _16._Structural_Design_Patterns.Formatting.ConcreteDecorators
{
    public class ItalicFormattingDecorator : BaseFormatDecorator
    {
        public ItalicFormattingDecorator(IFormatting wrappee) : base(wrappee)
        {
        }

        public override string FormatText()
        {
            return $"{_wrappee.FormatText()} with italic formatting";
        }
    }
}
