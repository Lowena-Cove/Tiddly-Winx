using Kaijinix.Common.Utilities;
using System;
using System.Text.Json.Serialization;

namespace Kaijinix.Common.Configuration.Hid
{
    // This enum was duplicated from Kaijinix.HLE.HOS.Services.Hid.PlayerIndex and should be kept identical
    [Flags]
    [JsonConverter(typeof(TypedStringEnumConverter<ControllerType>))]
    public enum ControllerType
    {
        None,
        ProController = 1 << 0,
        Handheld = 1 << 1,
        JoyconPair = 1 << 2,
        JoyconLeft = 1 << 3,
        JoyconRight = 1 << 4,
        Invalid = 1 << 5,
        Pokeball = 1 << 6,
        SystemExternal = 1 << 29,
        System = 1 << 30,
    }
}
