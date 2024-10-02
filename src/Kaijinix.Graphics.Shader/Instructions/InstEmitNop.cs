using Kaijinix.Graphics.Shader.Decoders;
using Kaijinix.Graphics.Shader.Translation;

namespace Kaijinix.Graphics.Shader.Instructions
{
    static partial class InstEmit
    {
        public static void Nop(EmitterContext context)
        {
            context.GetOp<InstNop>();

            // No operation.
        }
    }
}
