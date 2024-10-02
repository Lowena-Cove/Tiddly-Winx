using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter.Sink;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Parameter.Sink
{
    class CircularBufferParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x24, Unsafe.SizeOf<CircularBufferParameter>());
        }
    }
}
