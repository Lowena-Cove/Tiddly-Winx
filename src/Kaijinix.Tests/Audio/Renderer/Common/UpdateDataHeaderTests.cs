using NUnit.Framework;
using Kaijinix.Audio.Renderer.Common;
using System.Runtime.CompilerServices;

namespace Kaijinix.Tests.Audio.Renderer.Common
{
    class UpdateDataHeaderTests
    {
        [Test]
        public void EnsureTypeSize()
        {
            Assert.AreEqual(0x40, Unsafe.SizeOf<UpdateDataHeader>());
        }
    }
}
