using Kaijinix.Common.Logging;
using Kaijinix.HLE.HOS.Services.Nim.ShopServiceAccessServerInterface.ShopServiceAccessServer;

namespace Kaijinix.HLE.HOS.Services.Nim.ShopServiceAccessServerInterface
{
    class IShopServiceAccessServer : IpcService
    {
        public IShopServiceAccessServer() { }

        [CommandCmif(0)]
        // CreateAccessorInterface(u8) -> object<nn::ec::IShopServiceAccessor>
        public ResultCode CreateAccessorInterface(ServiceCtx context)
        {
            MakeObject(context, new IShopServiceAccessor(context.Device.System));

            Logger.Stub?.PrintStub(LogClass.ServiceNim);

            return ResultCode.Success;
        }
    }
}
