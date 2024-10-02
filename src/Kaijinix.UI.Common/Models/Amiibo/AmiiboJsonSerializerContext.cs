using System.Text.Json.Serialization;

namespace Kaijinix.UI.Common.Models.Amiibo
{
    [JsonSerializable(typeof(AmiiboJson))]
    public partial class AmiiboJsonSerializerContext : JsonSerializerContext
    {
    }
}
