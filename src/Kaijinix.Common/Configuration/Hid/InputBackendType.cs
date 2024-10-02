using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration.Hid
{
    [JsonConverter(typeof(TypedStringEnumConverter<InputBackendType>))]
    public enum InputBackendType
    {
        Invalid,
        WindowKeyboard,
        GamepadSDL2,
    }
}
