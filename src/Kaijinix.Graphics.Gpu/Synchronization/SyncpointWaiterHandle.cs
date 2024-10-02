using System;

namespace Kaijinix.Graphics.Gpu.Synchronization
{
    public class SyncpointWaiterHandle
    {
        internal uint Threshold;
        internal Action<SyncpointWaiterHandle> Callback;
    }
}
