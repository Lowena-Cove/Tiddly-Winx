using System;
using System.Collections.Generic;

namespace Kaijinix.Cpu.LightningJit
{
    interface IStackWalker
    {
        IEnumerable<ulong> GetCallStack(IntPtr framePointer, IntPtr codeRegionStart, int codeRegionSize, IntPtr codeRegion2Start, int codeRegion2Size);
    }
}
