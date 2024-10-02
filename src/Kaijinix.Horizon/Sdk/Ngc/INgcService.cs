using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;
using System;

namespace Kaijinix.Horizon.Sdk.Ngc
{
    interface INgcService : IServiceObject
    {
        Result GetContentVersion(out uint version);
        Result Check(out uint checkMask, ReadOnlySpan<byte> text, uint regionMask, ProfanityFilterOption option);
        Result Mask(out int maskedWordsCount, Span<byte> filteredText, ReadOnlySpan<byte> text, uint regionMask, ProfanityFilterOption option);
        Result Reload();
    }
}
