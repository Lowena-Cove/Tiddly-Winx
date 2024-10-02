using Kaijinix.Common.Memory;
using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Ldn.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x44)]
    struct SecurityConfig
    {
        public SecurityMode SecurityMode;
        public ushort PassphraseSize;
        public Array64<byte> Passphrase;
    }
}
