using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer
{
    class AudioRendererConfigurationTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x34, Unsafe.SizeOf<AudioRendererConfiguration>());
        }
    }
}
