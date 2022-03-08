using System;
using System.Runtime.Serialization;

namespace MarsRoverProject.Exceptions
{
    [Serializable]
    public class OutOfSurfaceException : Exception
    {
        public OutOfSurfaceException()
        {
        }

        public OutOfSurfaceException(string message) : base(message)
        {
        }

        public OutOfSurfaceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfSurfaceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}