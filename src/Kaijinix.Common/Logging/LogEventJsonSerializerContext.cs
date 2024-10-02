using System.Text.Json.Serialization;

namespace Kaijinix.Common.Logging
{
    [JsonSerializable(typeof(LogEventArgsJson))]
    internal partial class LogEventJsonSerializerContext : JsonSerializerContext
    {
    }
}
