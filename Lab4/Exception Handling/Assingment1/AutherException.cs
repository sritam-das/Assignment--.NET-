using System;
using System.Runtime.Serialization;

namespace Assingment1
{
    [Serializable]
    internal class AutherException : Exception
    {
        public AutherException()
        {
        }

        public AutherException(string message) : base(message)
        {
        }

        public AutherException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AutherException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}