using Kaijinix.Graphics.Shader.StructuredIr;
using Kaijinix.Graphics.Shader.Translation;

using static Kaijinix.Graphics.Shader.CodeGen.Glsl.Instructions.InstGenHelper;

namespace Kaijinix.Graphics.Shader.CodeGen.Glsl.Instructions
{
    static class InstGenShuffle
    {
        public static string Shuffle(CodeGenContext context, AstOperation operation)
        {
            string value = GetSourceExpr(context, operation.GetSource(0), AggregateType.FP32);
            string index = GetSourceExpr(context, operation.GetSource(1), AggregateType.U32);

            if (context.HostCapabilities.SupportsShaderBallot)
            {
                return $"readInvocationARB({value}, {index})";
            }
            else
            {
                return $"subgroupShuffle({value}, {index})";
            }
        }
    }
}
