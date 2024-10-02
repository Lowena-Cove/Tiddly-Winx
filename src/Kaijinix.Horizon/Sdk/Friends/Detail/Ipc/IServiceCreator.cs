using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Account;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.Sdk.Friends.Detail.Ipc
{
    interface IServiceCreator : IServiceObject
    {
        Result CreateFriendService(out IFriendService friendService);
        Result CreateNotificationService(out INotificationService notificationService, Uid userId);
        Result CreateDaemonSuspendSessionService(out IDaemonSuspendSessionService daemonSuspendSessionService);
    }
}
