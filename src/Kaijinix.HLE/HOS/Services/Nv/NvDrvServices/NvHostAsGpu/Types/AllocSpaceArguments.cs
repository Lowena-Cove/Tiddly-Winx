using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Nv.NvDrvServices.NvHostAsGpu.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct AllocSpaceArguments
    {
        public uint Pages;
        public uint PageSize;
        public AddressSpaceFlags Flags;
        public uint Padding;
        public ulong Offset;
    }
}
