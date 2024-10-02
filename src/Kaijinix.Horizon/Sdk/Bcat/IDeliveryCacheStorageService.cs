using LibHac.Bcat;
using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;
using System;

namespace Kaijinix.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheStorageService : IServiceObject
    {
        Result CreateDirectoryService(out IDeliveryCacheDirectoryService service);
        Result CreateFileService(out IDeliveryCacheFileService service);
        Result EnumerateDeliveryCacheDirectory(out int count, Span<DirectoryName> directoryNames);
    }
}
