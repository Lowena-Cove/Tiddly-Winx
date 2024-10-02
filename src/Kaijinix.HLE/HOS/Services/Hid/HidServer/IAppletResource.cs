using Kaijinix.HLE.HOS.Ipc;
using Kaijinix.HLE.HOS.Kernel.Memory;
using Kaijinix.Horizon.Common;
using System;

namespace Kaijinix.HLE.HOS.Services.Hid.HidServer
{
    class IAppletResource : IpcService
    {
        private readonly KSharedMemory _hidSharedMem;
        private int _hidSharedMemHandle;

        public IAppletResource(KSharedMemory hidSharedMem)
        {
            _hidSharedMem = hidSharedMem;
        }

        [CommandCmif(0)]
        // GetSharedMemoryHandle() -> handle<copy>
        public ResultCode GetSharedMemoryHandle(ServiceCtx context)
        {
            if (_hidSharedMemHandle == 0)
            {
                if (context.Process.HandleTable.GenerateHandle(_hidSharedMem, out _hidSharedMemHandle) != Result.Success)
                {
                    throw new InvalidOperationException("Out of handles!");
                }
            }

            context.Response.HandleDesc = IpcHandleDesc.MakeCopy(_hidSharedMemHandle);

            return ResultCode.Success;
        }
    }
}
