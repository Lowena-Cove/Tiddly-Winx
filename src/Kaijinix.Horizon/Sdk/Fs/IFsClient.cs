using Kaijinix.Horizon.Common;
using System;

namespace Kaijinix.Horizon.Sdk.Fs
{
    public interface IFsClient
    {
        Result QueryMountSystemDataCacheSize(out long size, ulong dataId);
        Result MountSystemData(string mountName, ulong dataId);
        Result OpenFile(out FileHandle handle, string path, OpenMode openMode);
        Result ReadFile(FileHandle handle, long offset, Span<byte> destination);
        Result GetFileSize(out long size, FileHandle handle);
        void CloseFile(FileHandle handle);
        void Unmount(string mountName);
    }
}
