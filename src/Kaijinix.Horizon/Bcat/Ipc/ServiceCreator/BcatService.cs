using Kaijinix.Horizon.Bcat.Types;
using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Bcat;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Bcat.Ipc
{
    partial class BcatService : IBcatService
    {
        public BcatService(BcatServicePermissionLevel permissionLevel) { }

        [CmifCommand(10100)]
        public Result RequestSyncDeliveryCache(out IDeliveryCacheProgressService deliveryCacheProgressService)
        {
            deliveryCacheProgressService = new DeliveryCacheProgressService();

            return Result.Success;
        }
    }
}
