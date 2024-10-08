using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Arp;
using Kaijinix.Horizon.Sdk.Arp.Detail;
using Kaijinix.Horizon.Sdk.Ns;
using Kaijinix.Horizon.Sdk.Sf;
using Kaijinix.Horizon.Sdk.Sf.Hipc;
using System;

namespace Kaijinix.Horizon.Arp.Ipc
{
    partial class Registrar : IRegistrar, IServiceObject
    {
        private readonly ApplicationInstance _applicationInstance;

        public Registrar(ApplicationInstance applicationInstance)
        {
            _applicationInstance = applicationInstance;
        }

        [CmifCommand(0)]
        public Result Issue(out ulong applicationInstanceId)
        {
            throw new NotImplementedException();
        }

        [CmifCommand(1)]
        public Result SetApplicationLaunchProperty(ApplicationLaunchProperty applicationLaunchProperty)
        {
            if (_applicationInstance.LaunchProperty != null)
            {
                return ArpResult.DataAlreadyBound;
            }

            _applicationInstance.LaunchProperty = applicationLaunchProperty;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result SetApplicationControlProperty([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.FixedSize, 0x4000)] in ApplicationControlProperty applicationControlProperty)
        {
            if (_applicationInstance.ControlProperty != null)
            {
                return ArpResult.DataAlreadyBound;
            }

            _applicationInstance.ControlProperty = applicationControlProperty;

            return Result.Success;
        }
    }
}
