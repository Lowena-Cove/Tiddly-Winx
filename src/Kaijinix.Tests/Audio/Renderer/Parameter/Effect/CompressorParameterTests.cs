using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter.Effect;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Parameter.Effect
{
    class CompressorParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x38, Unsafe.SizeOf<CompressorParameter>());
        }
    }
}
