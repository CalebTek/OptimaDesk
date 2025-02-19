using System.Runtime.Serialization;

namespace OptimaDesk.Common.Exceptions
{
    public class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException() : base("Forbidden")
        {
        }

        public ForbiddenAccessException(string message) : base(message)
        {
        }

        protected ForbiddenAccessException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
