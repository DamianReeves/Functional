namespace Functional.Runtime
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class FunctionalException : Exception
    {        
        public FunctionalException()
        {
        }

        public FunctionalException(string message)
            : base(message)
        {
        }

        public FunctionalException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected FunctionalException(
            SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}