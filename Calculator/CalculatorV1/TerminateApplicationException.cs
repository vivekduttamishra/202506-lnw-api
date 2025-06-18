using System.Runtime.Serialization;

namespace ConceptArchitect.Calculators
{
    [Serializable]
    internal class TerminateApplicationException : Exception
    {
        public TerminateApplicationException()
        {
        }

        public TerminateApplicationException(string? message) : base(message)
        {
        }

        public TerminateApplicationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TerminateApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}