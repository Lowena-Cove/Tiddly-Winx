using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Parameter
{
    class MixInParameterDirtyOnlyUpdateTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x20, Unsafe.SizeOf<MixInParameterDirtyOnlyUpdate>());
        }
    }
}
