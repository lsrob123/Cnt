using System;

namespace CntApp.Utilities.Infrastructure
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException()
        {
        }

        public ForbiddenException(string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }
}