using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration
{
    [JsonConverter(typeof(TypedStringEnumConverter<GraphicsDebugLevel>))]
    public enum GraphicsDebugLevel
    {
        None,
        Error,
        Slowdowns,
        All,
    }
}
