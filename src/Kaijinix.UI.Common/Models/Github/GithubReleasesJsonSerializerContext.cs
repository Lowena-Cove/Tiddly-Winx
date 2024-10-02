using System.Text.Json.Serialization;

namespace Kaijinix.UI.Common.Models.Github
{
    [JsonSerializable(typeof(GithubReleasesJsonResponse), GenerationMode = JsonSourceGenerationMode.Metadata)]
    public partial class GithubReleasesJsonSerializerContext : JsonSerializerContext
    {
    }
}
