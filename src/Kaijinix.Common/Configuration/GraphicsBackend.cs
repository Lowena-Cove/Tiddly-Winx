using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration
{
    [JsonConverter(typeof(TypedStringEnumConverter<GraphicsBackend>))]
    public enum GraphicsBackend
    {
        Vulkan,
        OpenGl,
    }
}
