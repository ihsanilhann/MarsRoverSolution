using System;
using System.Runtime.Serialization;

namespace MarsRoverProject.Exceptions
{
    [Serializable]
    public class SurfaceNotCreatedException : Exception
    {
        public SurfaceNotCreatedException()
        {
        }

        public SurfaceNotCreatedException(string message) : base(message)
        {
        }

        public SurfaceNotCreatedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SurfaceNotCreatedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}