using Kaijinix.Common.Memory;

namespace Kaijinix.Graphics.Nvdec.Vp9
{
    internal struct TileBuffer
    {
        public int Col;
        public ArrayPtr<byte> Data;
        public int Size;
    }
}
