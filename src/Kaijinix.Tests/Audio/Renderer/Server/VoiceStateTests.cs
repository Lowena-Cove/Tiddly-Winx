using NUnit.Framework;
using Kaijinix.Audio.Renderer.Server.Voice;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Server
{
    class VoiceStateTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.LessOrEqual(Unsafe.SizeOf<VoiceState>(), 0x220);
        }
    }
}
