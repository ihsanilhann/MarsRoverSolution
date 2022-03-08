using System;
using System.Runtime.Serialization;

namespace MarsRoverProject.Exceptions
{
    [Serializable]
    public class WrongParameterException : Exception
    {
        public WrongParameterException()
        {
        }

        public WrongParameterException(string message) : base(message)
        {
        }

        public WrongParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongParameterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}