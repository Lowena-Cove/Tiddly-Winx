using NUnit.Framework;
using Kaijinix.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Common
{
    class VoiceUpdateStateTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.LessOrEqual(Unsafe.SizeOf<VoiceUpdateState>(), 0x100);
        }
    }
}
