using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.LogManager.Ipc;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Lm
{
    interface ILogService : IServiceObject
    {
        Result OpenLogger(out LmLogger logger, ulong pid);
    }
}
