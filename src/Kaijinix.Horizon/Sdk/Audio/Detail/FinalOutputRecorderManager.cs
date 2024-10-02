using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Applet;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Audio.Detail
{
    partial class FinalOutputRecorderManager : IFinalOutputRecorderManager
    {
        [CmifCommand(0)]
        public Result OpenFinalOutputRecorder(
            out IFinalOutputRecorder recorder,
            FinalOutputRecorderParameter parameter,
            [CopyHandle] int processHandle,
            out FinalOutputRecorderParameterInternal outParameter,
            AppletResourceUserId appletResourceId)
        {
            recorder = new FinalOutputRecorder(processHandle);
            outParameter = new(parameter.SampleRate, 2, 0);

            return Result.Success;
        }
    }
}
