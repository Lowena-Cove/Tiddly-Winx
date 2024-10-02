using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;
using System;

namespace Kaijinix.Horizon.Sdk.Lm
{
    interface ILmLogger : IServiceObject
    {
        Result Log(Span<byte> message);
        Result SetDestination(LogDestination destination);
    }
}
