using Kaijinix.Horizon.MmNv.Ipc;
using Kaijinix.Horizon.Sdk.Sf.Hipc;
using Kaijinix.Horizon.Sdk.Sm;

namespace Kaijinix.Horizon.MmNv
{
    class MmNvIpcServer
    {
        private const int MaxSessionsCount = 40;

        private const int PointerBufferSize = 0;
        private const int MaxDomains = 0;
        private const int MaxDomainObjects = 0;
        private const int MaxPortsCount = 1;

        private static readonly ManagerOptions _managerOptions = new(PointerBufferSize, MaxDomains, MaxDomainObjects, false);

        private SmApi _sm;
        private ServerManager _serverManager;

        public void Initialize()
        {
            HeapAllocator allocator = new();

            _sm = new SmApi();
            _sm.Initialize().AbortOnFailure();

            _serverManager = new ServerManager(allocator, _sm, MaxPortsCount, _managerOptions, MaxSessionsCount);

            _serverManager.RegisterObjectForServer(new Request(), ServiceName.Encode("mm:u"), MaxSessionsCount);
        }

        public void ServiceRequests()
        {
            _serverManager.ServiceRequests();
        }

        public void Shutdown()
        {
            _serverManager.Dispose();
            _sm.Dispose();
        }
    }
}
