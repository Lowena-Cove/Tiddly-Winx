using NUnit.Framework;
using Kaijinix.Audio.Renderer.Server.Mix;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Server
{
    class MixStateTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x940, Unsafe.SizeOf<MixState>());
        }
    }
}
