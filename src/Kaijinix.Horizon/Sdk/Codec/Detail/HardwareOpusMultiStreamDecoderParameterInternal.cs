using Kaijinix.Common.Memory;
using System.Runtime.InteropServices;

namespace Kaijinix.Horizon.Sdk.Codec.Detail
{
    [StructLayout(LayoutKind.Sequential, Size = 0x110)]
    struct HardwareOpusMultiStreamDecoderParameterInternal
    {
        public int SampleRate;
        public int ChannelsCount;
        public int NumberOfStreams;
        public int NumberOfStereoStreams;
        public Array256<byte> ChannelMappings;
    }
}
