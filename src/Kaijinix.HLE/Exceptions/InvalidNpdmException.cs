using System;

namespace Kaijinix.HLE.Exceptions
{
    public class InvalidNpdmException : Exception
    {
        public InvalidNpdmException(string message) : base(message) { }
    }
}
