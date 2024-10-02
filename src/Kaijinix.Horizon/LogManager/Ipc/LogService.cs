using Kaijinix.Horizon.Common;
using Kaijinix.Horizon.Sdk.Lm;
using Kaijinix.Horizon.Sdk.Sf;

namespace Kaijinix.Horizon.LogManager.Ipc
{
    partial class LogService : ILogService
    {
        public LogDestination LogDestination { get; set; } = LogDestination.TargetManager;

        [CmifCommand(0)]
        public Result OpenLogger(out LmLogger logger, [ClientProcessId] ulong pid)
        {
            // NOTE: Internal name is Logger, but we rename it to LmLogger to avoid name clash with Kaijinix.Common.Logging logger.
            logger = new LmLogger(this, pid);

            return Result.Success;
        }
    }
}
