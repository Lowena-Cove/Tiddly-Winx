using System;

namespace Kaijinix.Horizon.Sdk.Codec.Detail
{
    [Flags]
    enum OpusDecoderFlags : uint
    {
        None,
        LargeFrameSize = 1 << 0,
    }
}
