using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Kaijinix.Ava.Common.Locale;
using Kaijinix.UI.Common.Configuration;
using System.IO;
using System.Reflection;

namespace Kaijinix.Ava.UI.Windows
{
    public class StyleableWindow : Window
    {
        public Bitmap IconImage { get; set; }

        public StyleableWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            TransparencyLevelHint = new[] { WindowTransparencyLevel.None };

            using Stream stream = Assembly.GetAssembly(typeof(ConfigurationState)).GetManifestResourceStream("Kaijinix.UI.Common.Resources.Logo_Kaijinix.png");

            Icon = new WindowIcon(stream);
            stream.Position = 0;
            IconImage = new Bitmap(stream);

            LocaleManager.Instance.LocaleChanged += LocaleChanged;
            LocaleChanged();
        }

        private void LocaleChanged()
        {
            FlowDirection = LocaleManager.Instance.IsRTL() ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.SystemChrome | ExtendClientAreaChromeHints.OSXThickTitleBar;
        }
    }
}
