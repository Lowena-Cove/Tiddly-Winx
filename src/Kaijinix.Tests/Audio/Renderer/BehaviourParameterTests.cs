using NUnit.Framework;
using Kaijinix.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer
{
    class BehaviourParameterTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x10, Unsafe.SizeOf<BehaviourParameter>());
            Assert.AreEqual(0x10, Unsafe.SizeOf<BehaviourParameter.ErrorInfo>());
        }
    }
}
