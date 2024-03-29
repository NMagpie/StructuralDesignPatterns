namespace _16._Structural_Design_Patterns.Formatting
{
    public abstract class BaseFormatDecorator : IFormatting
    {
        protected IFormatting _wrappee;

        public BaseFormatDecorator(IFormatting wrappee)
        {
            _wrappee = wrappee;
        }

        public abstract string FormatText();

        public string FormatText(string text)
        {
            return $"{text}{_wrappee.FormatText()}";
        }
    }
}
