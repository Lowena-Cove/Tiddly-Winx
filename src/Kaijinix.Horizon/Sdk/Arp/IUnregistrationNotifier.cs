using Kaijinix.Horizon.Common;

namespace Kaijinix.Horizon.Sdk.Arp
{
    public interface IUnregistrationNotifier
    {
        public Result GetReadableHandle(out int readableHandle);
    }
}
