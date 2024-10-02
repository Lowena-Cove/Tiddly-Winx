using Kaijinix.Graphics.GAL;
using Kaijinix.Memory.Range;

namespace Kaijinix.Graphics.Gpu.Memory
{
    /// <summary>
    /// GPU Index Buffer information.
    /// </summary>
    struct IndexBuffer
    {
        public MultiRange Range;
        public IndexType Type;
    }
}
