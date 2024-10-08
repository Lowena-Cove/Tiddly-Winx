using Kaijinix.Common.Memory;
using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Ldn.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0xC)]
    struct AddressEntry
    {
        public uint Ipv4Address;
        public Array6<byte> MacAddress;
        public ushort Reserved;
    }
}
