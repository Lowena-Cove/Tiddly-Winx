using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Bcat
{
    internal interface IBcatService : IServiceObject
    {
        Result RequestSyncDeliveryCache(out IDeliveryCacheProgressService deliveryCacheProgressService);
    }
}
