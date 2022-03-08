using System;
using System.Runtime.Serialization;

namespace MarsRoverProject
{
    [Serializable]
    public class NotEnoughArgumentException : Exception
    {
        public NotEnoughArgumentException()
        {
        }

        public NotEnoughArgumentException(string message) : base(message)
        {
        }

        public NotEnoughArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotEnoughArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}