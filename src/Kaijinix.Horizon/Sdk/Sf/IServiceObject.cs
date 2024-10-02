using System.Collections.Generic;

namespace Kaijinix.Horizon.Sdk.Sf
{
    interface IServiceObject
    {
        IReadOnlyDictionary<int, CommandHandler> GetCommandHandlers();
    }
}
