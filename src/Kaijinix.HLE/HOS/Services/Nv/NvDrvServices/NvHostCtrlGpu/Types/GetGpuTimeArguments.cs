using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Nv.NvDrvServices.NvHostCtrlGpu.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct GetGpuTimeArguments
    {
        public ulong Timestamp;
        public ulong Reserved;
    }
}
