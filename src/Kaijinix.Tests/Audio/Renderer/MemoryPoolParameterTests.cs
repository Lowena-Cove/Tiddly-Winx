using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer
{
    class MemoryPoolParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x20, Unsafe.SizeOf<MemoryPoolInParameter>());
            Assert.AreEqual(0x10, Unsafe.SizeOf<MemoryPoolOutStatus>());
        }
    }
}
