using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter.Effect;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Parameter.Effect
{
    class BufferMixerParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x94, Unsafe.SizeOf<BufferMixParameter>());
        }
    }
}
