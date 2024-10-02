using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.UI.Common.Configuration
{
    [JsonConverter(typeof(TypedStringEnumConverter<AudioBackend>))]
    public enum AudioBackend
    {
        Dummy,
        OpenAl,
        SoundIo,
        SDL2,
    }
}
