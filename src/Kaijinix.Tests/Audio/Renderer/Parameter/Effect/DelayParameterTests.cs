using NUnit.Framework;
using Kaijinix.Audio.Renderer.Parameter.Effect;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Parameter.Effect
{
    class DelayParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x35, Unsafe.SizeOf<DelayParameter>());
        }
    }
}
