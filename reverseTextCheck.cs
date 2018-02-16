using System;
using System.Runtime.Serialization;

namespace HW12
{
    [Serializable]
    internal class reverseTextCheck : Exception
    {
        public reverseTextCheck()
        {
        }

        public reverseTextCheck(string message) : base(message)
        {
        }

        public reverseTextCheck(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected reverseTextCheck(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}