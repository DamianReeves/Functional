namespace Functional.Runtime
{
    using Microsoft.Scripting.Runtime;

    public class ParseResult
    {
        private readonly object value;

        public ParseResult(object value)
        {
            this.value = value;
        }

        public object Value
        {
            get
            {
                return this.value;
            }
        }

        public object Evaluate(Scope scope)
        {
            return this.Value;
        }
    }
}