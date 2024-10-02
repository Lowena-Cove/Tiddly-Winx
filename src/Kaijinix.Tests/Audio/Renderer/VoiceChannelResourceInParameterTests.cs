using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer
{
    class VoiceChannelResourceInParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x70, Unsafe.SizeOf<VoiceChannelResourceInParameter>());
        }
    }
}
