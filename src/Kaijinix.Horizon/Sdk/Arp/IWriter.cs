using Kaijinix.Horizon.Common;

namespace Kaijinix.Horizon.Sdk.Arp
{
    public interface IWriter
    {
        public Result AcquireRegistrar(out IRegistrar registrar);
        public Result UnregisterApplicationInstance(ulong applicationInstanceId);
        public Result AcquireApplicationProcessPropertyUpdater(out IUpdater updater, ulong applicationInstanceId);
        public Result AcquireApplicationCertificateUpdater(out IUpdater updater, ulong applicationInstanceId);
    }
}
