using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Nv.NvDrvServices.NvHostChannel.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct SetErrorNotifierArguments
    {
        public ulong Offset;
        public ulong Size;
        public uint Mem;
        public uint Reserved;
    }
}
