using NUnit.Framework;
using Kaijinix.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Common
{
    class WaveBufferTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x30, Unsafe.SizeOf<WaveBuffer>());
        }
    }
}
