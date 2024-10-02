namespace Kaijinix.HLE.HOS.Kernel.Ipc
{
    enum ChannelState
    {
        NotInitialized,
        Open,
        ClientDisconnected,
        ServerDisconnected,
    }
}
