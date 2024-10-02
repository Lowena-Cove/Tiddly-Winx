using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration
{
    [JsonConverter(typeof(TypedStringEnumConverter<AntiAliasing>))]
    public enum AntiAliasing
    {
        None,
        Fxaa,
        SmaaLow,
        SmaaMedium,
        SmaaHigh,
        SmaaUltra,
    }
}
