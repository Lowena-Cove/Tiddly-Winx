using Kaijinix.Common.Memory;
using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Ldn.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x20)]
    struct NetworkConfig
    {
        public IntentId IntentId;
        public ushort Channel;
        public byte NodeCountMax;
        public byte Reserved1;
        public ushort LocalCommunicationVersion;
        public Array10<byte> Reserved2;
    }
}
