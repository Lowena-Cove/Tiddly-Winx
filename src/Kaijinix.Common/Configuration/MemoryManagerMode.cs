using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration
{
    [JsonConverter(typeof(TypedStringEnumConverter<MemoryManagerMode>))]
    public enum MemoryManagerMode : byte
    {
        SoftwarePageTable,
        HostMapped,
        HostMappedUnsafe,
    }
}
