using Kaijinix.Graphics.Shader.StructuredIr;
using Kaijinix.Graphics.Shader.Translation;

namespace Kaijinix.Graphics.Shader.CodeGen
{
    readonly struct CodeGenParameters
    {
        public readonly AttributeUsage AttributeUsage;
        public readonly ShaderDefinitions Definitions;
        public readonly ShaderProperties Properties;
        public readonly HostCapabilities HostCapabilities;
        public readonly ILogger Logger;
        public readonly TargetApi TargetApi;

        public CodeGenParameters(
            AttributeUsage attributeUsage,
            ShaderDefinitions definitions,
            ShaderProperties properties,
            HostCapabilities hostCapabilities,
            ILogger logger,
            TargetApi targetApi)
        {
            AttributeUsage = attributeUsage;
            Definitions = definitions;
            Properties = properties;
            HostCapabilities = hostCapabilities;
            Logger = logger;
            TargetApi = targetApi;
        }
    }
}
