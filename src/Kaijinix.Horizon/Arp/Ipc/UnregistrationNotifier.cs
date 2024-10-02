using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Arp;
using Kaijinix.Horizon.Sdk.Arp.Detail;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Arp.Ipc
{
    partial class UnregistrationNotifier : IUnregistrationNotifier, IServiceObject
    {
        private readonly ApplicationInstanceManager _applicationInstanceManager;

        public UnregistrationNotifier(ApplicationInstanceManager applicationInstanceManager)
        {
            _applicationInstanceManager = applicationInstanceManager;
        }

        [CmifCommand(0)]
        public Result GetReadableHandle([CopyHandle] out int readableHandle)
        {
            readableHandle = _applicationInstanceManager.EventHandle;

            return Result.Success;
        }
    }
}
