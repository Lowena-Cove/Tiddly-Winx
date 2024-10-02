using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration.Hid.Controller.Motion
{
    [JsonConverter(typeof(TypedStringEnumConverter<MotionInputBackendType>))]
    public enum MotionInputBackendType : byte
    {
        Invalid,
        GamepadDriver,
        CemuHook,
    }
}
