using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter.Sink;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Parameter.Sink
{
    class DeviceParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x11C, Unsafe.SizeOf<DeviceParameter>());
        }
    }
}
