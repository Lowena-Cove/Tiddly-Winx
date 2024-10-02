using LibHac.Bcat;
using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;
using System;

namespace Kaijinix.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheDirectoryService : IServiceObject
    {
        Result GetCount(out int count);
        Result Open(DirectoryName directoryName);
        Result Read(out int entriesRead, Span<DeliveryCacheDirectoryEntry> entriesBuffer);
    }
}
