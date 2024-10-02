using Kaijinix.HLE.HOS.Ipc;
using Kaijinix.HLE.HOS.Kernel.Process;
using Kaijinix.HLE.HOS.Kernel.Threading;
using Kaijinix.Memory;
using System.IO;

namespace Kaijinix.HLE.HOS
{
    class ServiceCtx
    {
        public Switch Device { get; }
        public KProcess Process { get; }
        public IVirtualMemoryManager Memory { get; }
        public KThread Thread { get; }
        public IpcMessage Request { get; }
        public IpcMessage Response { get; }
        public BinaryReader RequestData { get; }
        public BinaryWriter ResponseData { get; }

        public ServiceCtx(
            Switch device,
            KProcess process,
            IVirtualMemoryManager memory,
            KThread thread,
            IpcMessage request,
            IpcMessage response,
            BinaryReader requestData,
            BinaryWriter responseData)
        {
            Device = device;
            Process = process;
            Memory = memory;
            Thread = thread;
            Request = request;
            Response = response;
            RequestData = requestData;
            ResponseData = responseData;
        }
    }
}
