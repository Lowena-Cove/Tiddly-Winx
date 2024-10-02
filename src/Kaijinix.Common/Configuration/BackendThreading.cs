using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration
{
    [JsonConverter(typeof(TypedStringEnumConverter<BackendThreading>))]
    public enum BackendThreading
    {
        Auto,
        Off,
        On,
    }
}
