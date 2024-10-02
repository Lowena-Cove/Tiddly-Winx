using System;

namespace Kaijinix.HLE.HOS.Services.Am.AppletAE
{
    [Flags]
    enum LibraryAppletMode : uint
    {
        AllForeground,
        PartialForeground,
        NoUi,
        PartialForegroundWithIndirectDisplay,
        AllForegroundInitiallyHidden,
    }
}
