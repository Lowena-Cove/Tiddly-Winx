using Kaijinix.HLE.HOS.Services.Nv.Types;
using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Nv.NvDrvServices.NvHostCtrl.Types
{
    [StructLayout(LayoutKind.Sequential)]
    struct EventWaitArguments
    {
        public NvFence Fence;
        public int Timeout;
        public uint Value;
    }
}
