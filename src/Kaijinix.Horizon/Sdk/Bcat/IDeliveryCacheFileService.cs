using LibHac.Bcat;
using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;
using System;

namespace Kaijinix.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheFileService : IServiceObject
    {
        Result GetDigest(out Digest digest);
        Result GetSize(out long size);
        Result Open(DirectoryName directoryName, FileName fileName);
        Result Read(long offset, out long bytesRead, Span<byte> data);
    }
}
