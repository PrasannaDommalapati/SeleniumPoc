using System;
using System.Runtime.Serialization;

namespace SeleniumPoc
{
    public class SeleniumPocException : Exception
    {
        public SeleniumPocException() : base()
        {
        }

        public SeleniumPocException(string message) : base(message)
        {
        }

        public SeleniumPocException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SeleniumPocException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
