using System;

namespace Kaijinix.UI.App.Common
{
    public class ApplicationCountUpdatedEventArgs : EventArgs
    {
        public int NumAppsFound { get; set; }
        public int NumAppsLoaded { get; set; }
    }
}
