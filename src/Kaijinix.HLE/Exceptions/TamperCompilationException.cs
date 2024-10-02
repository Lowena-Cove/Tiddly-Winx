using System;

namespace Kaijinix.HLE.Exceptions
{
    public class TamperCompilationException : Exception
    {
        public TamperCompilationException(string message) : base(message) { }
    }
}
