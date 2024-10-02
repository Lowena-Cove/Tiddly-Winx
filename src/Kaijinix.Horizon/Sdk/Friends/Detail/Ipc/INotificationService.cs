using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Friends.Detail.Ipc
{
    interface INotificationService : IServiceObject
    {
        Result GetEvent(out int eventHandle);
        Result Clear();
        Result Pop(out SizedNotificationInfo sizedNotificationInfo);
    }
}
