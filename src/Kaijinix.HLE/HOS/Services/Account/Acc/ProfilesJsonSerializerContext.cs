using Kaijinix.HLE.HOS.Services.Account.Acc.Types;
using System.Text.Json.Serialization;

namespace Kaijinix.HLE.HOS.Services.Account.Acc
{
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(ProfilesJson))]
    internal partial class ProfilesJsonSerializerContext : JsonSerializerContext
    {
    }
}
