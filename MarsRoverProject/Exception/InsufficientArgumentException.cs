using System;
using System.Runtime.Serialization;

namespace MarsRoverProject.Exceptions
{
    [Serializable]
    public class InsufficientArgumentException : Exception
    {
        public InsufficientArgumentException()
        {
        }

        public InsufficientArgumentException(string message) : base(message)
        {
        }

        public InsufficientArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InsufficientArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}