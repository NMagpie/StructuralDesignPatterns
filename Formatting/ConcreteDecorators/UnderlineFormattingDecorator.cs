namespace _16._Structural_Design_Patterns.Formatting.ConcreteDecorators
{
    public class UndelineFormattingDecorator : BaseFormatDecorator
    {
        public UndelineFormattingDecorator(IFormatting wrappee) : base(wrappee)
        {
        }

        public override string FormatText()
        {
            return $"{_wrappee.FormatText()} with underline formatting";
        }
    }
}
