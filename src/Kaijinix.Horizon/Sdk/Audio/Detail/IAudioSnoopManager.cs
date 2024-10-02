using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Audio.Detail
{
    interface IAudioSnoopManager : IServiceObject
    {
        Result EnableDspUsageMeasurement();
        Result DisableDspUsageMeasurement();
        Result GetDspUsage(out uint usage);
    }
}
