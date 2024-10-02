using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration.Hid.Controller
{
    [JsonConverter(typeof(TypedStringEnumConverter<StickInputId>))]
    public enum StickInputId : byte
    {
        Unbound,
        Left,
        Right,

        Count,
    }
}
