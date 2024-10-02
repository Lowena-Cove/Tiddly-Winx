using Kaijinix.Horizon.Sdk.OsTypes;
using Kaijinix.Horizon.Sdk.Sf.Cmif;
using Kaijinix.Horizon.Sdk.Sm;

namespace Kaijinix.Horizon.Sdk.Sf.Hipc
{
    class Server : MultiWaitHolderOfHandle
    {
        public int PortIndex { get; }
        public int PortHandle { get; }
        public ServiceName Name { get; }
        public bool Managed { get; }
        public ServiceObjectHolder StaticObject { get; }

        public Server(
            int portIndex,
            int portHandle,
            ServiceName name,
            bool managed,
            ServiceObjectHolder staticHoder) : base(portHandle)
        {
            PortHandle = portHandle;
            Name = name;
            Managed = managed;

            if (staticHoder != null)
            {
                StaticObject = staticHoder;
            }
            else
            {
                PortIndex = portIndex;
            }
        }
    }
}
