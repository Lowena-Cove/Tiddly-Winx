using Kaijinix.Graphics.Device;
using Kaijinix.Graphics.Host1x;
using Kaijinix.Graphics.Nvdec;
using Kaijinix.Graphics.Vic;
using System;
using GpuContext = Kaijinix.Graphics.Gpu.GpuContext;

namespace Kaijinix.HLE.HOS.Services.Nv
{
    class Host1xContext : IDisposable
    {
        public DeviceMemoryManager Smmu { get; }
        public NvMemoryAllocator MemoryAllocator { get; }
        public Host1xDevice Host1x { get; }

        public Host1xContext(GpuContext gpu, ulong pid)
        {
            MemoryAllocator = new NvMemoryAllocator();
            Host1x = new Host1xDevice(gpu.Synchronization);
            Smmu = gpu.CreateDeviceMemoryManager(pid);
            var nvdec = new NvdecDevice(Smmu);
            var vic = new VicDevice(Smmu);
            Host1x.RegisterDevice(ClassId.Nvdec, nvdec);
            Host1x.RegisterDevice(ClassId.Vic, vic);
        }

        public void Dispose()
        {
            Host1x.Dispose();
        }
    }
}
