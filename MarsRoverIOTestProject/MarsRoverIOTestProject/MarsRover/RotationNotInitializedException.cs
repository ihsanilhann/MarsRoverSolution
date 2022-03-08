using System;
using System.Runtime.Serialization;

namespace MarsRoverProject.Exceptions
{
    [Serializable]
    public class RotationNotInitializedException : Exception
    {
        public RotationNotInitializedException()
        {
        }

        public RotationNotInitializedException(string message) : base(message)
        {
        }

        public RotationNotInitializedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RotationNotInitializedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}