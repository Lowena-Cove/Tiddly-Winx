using System.Runtime.InteropServices;

namespace Kaijinix.HLE.HOS.Services.Nv.NvDrvServices.NvMap
{
    [StructLayout(LayoutKind.Sequential)]
    struct NvMapGetId
    {
        public int Id;
        public int Handle;
    }
}
