using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration
{
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(List<DownloadableContentContainer>))]
    public partial class DownloadableContentJsonSerializerContext : JsonSerializerContext
    {
    }
}
