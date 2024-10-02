using System;

namespace Kaijinix.HLE.Exceptions
{
    class InvalidFirmwarePackageException : Exception
    {
        public InvalidFirmwarePackageException(string message) : base(message) { }
    }
}
