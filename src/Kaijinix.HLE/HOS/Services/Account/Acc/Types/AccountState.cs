using Kaijinix.Common.Utilities;
using System.Text.Json.Serialization;

namespace Kaijinix.HLE.HOS.Services.Account.Acc
{
    [JsonConverter(typeof(TypedStringEnumConverter<AccountState>))]
    public enum AccountState
    {
        Closed,
        Open,
    }
}
