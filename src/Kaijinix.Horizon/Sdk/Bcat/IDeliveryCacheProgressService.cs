using Kaijinix.Horizon.Bcat.Ipc.Types;
using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheProgressService : IServiceObject
    {
        Result GetEvent(out int handle);
        Result GetImpl(out DeliveryCacheProgressImpl deliveryCacheProgressImpl);
    }
}
