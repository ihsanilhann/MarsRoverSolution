using System;
using System.Runtime.Serialization;

namespace MarsRoverProject.Exceptions
{
    [Serializable]
    public class ArgumentCountException : Exception
    {
        public ArgumentCountException()
        {
        }

        public ArgumentCountException(string message) : base(message)
        {
        }

        public ArgumentCountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentCountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}