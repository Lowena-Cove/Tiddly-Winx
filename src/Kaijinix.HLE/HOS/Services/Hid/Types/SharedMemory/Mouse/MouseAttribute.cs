using System;

namespace Kaijinix.HLE.HOS.Services.Hid.Types.SharedMemory.Mouse
{
    [Flags]
    enum MouseAttribute : uint
    {
        None = 0,
        Transferable = 1 << 0,
        IsConnected = 1 << 1,
    }
}
