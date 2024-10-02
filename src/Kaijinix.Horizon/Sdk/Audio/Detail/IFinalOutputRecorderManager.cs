using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Applet;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Audio.Detail
{
    interface IFinalOutputRecorderManager : IServiceObject
    {
        Result OpenFinalOutputRecorder(
            out IFinalOutputRecorder recorder,
            FinalOutputRecorderParameter parameter,
            int processHandle,
            out FinalOutputRecorderParameterInternal outParameter,
            AppletResourceUserId appletResourceId);
    }
}
