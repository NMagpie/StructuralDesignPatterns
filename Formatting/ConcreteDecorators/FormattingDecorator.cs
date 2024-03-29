namespace _16._Structural_Design_Patterns.Formatting.ConcreteDecorators
{
    public class FormattingDecorator : IFormatting
    {
        public string Text { get; set; }

        public FormattingDecorator(string text)
        {
            Text = text;
        }

        public string FormatText()
        {
            return Text;
        }

        public IFormatting GetChild()
        {
            return null;
        }
    }
}
