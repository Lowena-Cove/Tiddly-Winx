using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kaijinix.UI.Common.Models.Amiibo
{
    public class AmiiboApiGamesSwitch
    {
        [JsonPropertyName("amiiboUsage")]
        public List<AmiiboApiUsage> AmiiboUsage { get; set; }
        [JsonPropertyName("gameID")]
        public List<string> GameId { get; set; }
        [JsonPropertyName("gameName")]
        public string GameName { get; set; }
    }
}
