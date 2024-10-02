using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf.Hipc;
using Kaijinix.Horizon.Sdk.Sm;
using Kaijinix.Horizon.Sm.Impl;
using Kaijinix.Horizon.Sm.Ipc;
using Kaijinix.Horizon.Sm.Types;
using System;

namespace Kaijinix.Horizon.Sm
{
    class SmServerManager : ServerManager
    {
        private readonly ServiceManager _serviceManager;

        public SmServerManager(ServiceManager serviceManager, HeapAllocator allocator, SmApi sm, int maxPorts, ManagerOptions options, int maxSessions) : base(allocator, sm, maxPorts, options, maxSessions)
        {
            _serviceManager = serviceManager;
        }

        protected override Result OnNeedsToAccept(int portIndex, Server server)
        {
            return (SmPortIndex)portIndex switch
            {
                SmPortIndex.User => AcceptImpl(server, new UserService(_serviceManager)),
                SmPortIndex.Manager => AcceptImpl(server, new ManagerService()),
                _ => throw new ArgumentOutOfRangeException(nameof(portIndex)),
            };
        }
    }
}
