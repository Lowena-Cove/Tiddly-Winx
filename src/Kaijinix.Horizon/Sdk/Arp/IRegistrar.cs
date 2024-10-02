using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Ns;

namespace Kaijinix.Horizon.Sdk.Arp
{
    public interface IRegistrar
    {
        public Result Issue(out ulong applicationInstanceId);
        public Result SetApplicationLaunchProperty(ApplicationLaunchProperty applicationLaunchProperty);
        public Result SetApplicationControlProperty(in ApplicationControlProperty applicationControlProperty);
    }
}
