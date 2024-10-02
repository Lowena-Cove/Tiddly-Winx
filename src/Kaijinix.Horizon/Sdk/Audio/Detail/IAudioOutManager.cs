using Kaijinix.Audio.Common;
using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Applet;
using Kaijinix.Horizon.Sdk.Sf;
using System;

namespace Kaijinix.Horizon.Sdk.Audio.Detail
{
    interface IAudioOutManager : IServiceObject
    {
        Result ListAudioOuts(out int count, Span<DeviceName> names);
        Result OpenAudioOut(
            out AudioOutputConfiguration outputConfig,
            out IAudioOut audioOut,
            Span<DeviceName> outName,
            AudioInputConfiguration inputConfig,
            AppletResourceUserId appletResourceId,
            int processHandle,
            ReadOnlySpan<DeviceName> name,
            ulong pid);
        Result ListAudioOutsAuto(out int count, Span<DeviceName> names);
        Result OpenAudioOutAuto(
            out AudioOutputConfiguration outputConfig,
            out IAudioOut audioOut,
            Span<DeviceName> outName,
            AudioInputConfiguration inputConfig,
            AppletResourceUserId appletResourceId,
            int processHandle,
            ReadOnlySpan<DeviceName> name,
            ulong pid);
    }
}
