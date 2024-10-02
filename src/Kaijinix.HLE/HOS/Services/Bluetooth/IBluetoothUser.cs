using Kaijinix.HLE.HOS.Ipc;
using Kaijinix.HLE.HOS.Services.Bluetooth.BluetoothDriver;
using Kaijinix.HLE.HOS.Services.Settings;

namespace Kaijinix.HLE.HOS.Services.Bluetooth
{
    [Service("bt")]
    class IBluetoothUser : IpcService
    {
        public IBluetoothUser(ServiceCtx context) { }

        [CommandCmif(9)]
        // RegisterBleEvent(pid) -> handle<copy>
        public ResultCode RegisterBleEvent(ServiceCtx context)
        {
            NxSettings.Settings.TryGetValue("bluetooth_debug!skip_boot", out object debugMode);

            if ((bool)debugMode)
            {
                context.Response.HandleDesc = IpcHandleDesc.MakeCopy(BluetoothEventManager.RegisterBleDebugEventHandle);
            }
            else
            {
                context.Response.HandleDesc = IpcHandleDesc.MakeCopy(BluetoothEventManager.RegisterBleEventHandle);
            }

            return ResultCode.Success;
        }
    }
}
