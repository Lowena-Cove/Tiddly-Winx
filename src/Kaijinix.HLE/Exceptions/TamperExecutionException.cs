using System;

namespace Kaijinix.HLE.Exceptions
{
    public class TamperExecutionException : Exception
    {
        public TamperExecutionException(string message) : base(message) { }
    }
}
