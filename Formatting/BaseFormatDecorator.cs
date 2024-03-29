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

        public IFormatting GetChild()
        {
            return _wrappee;
        }

        public void RemoveChild(IFormatting child)
        {
            Console.WriteLine();

            if (_wrappee.GetType().Equals(child.GetType()))
            {
                _wrappee = _wrappee.GetChild();
            }
        }
    }
}
