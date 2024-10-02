using NUnit.Framework;
using Kaijinix.Audio.Renderer.Server.Voice;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Server
{
    class WaveBufferTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x58, Unsafe.SizeOf<WaveBuffer>());
        }
    }
}
