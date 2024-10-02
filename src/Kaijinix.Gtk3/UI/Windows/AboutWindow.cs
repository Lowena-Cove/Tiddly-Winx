using Gtk;
using Kaijinix.Common.Utilities;
using Kaijinix.UI.Common.Helper;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;

namespace Kaijinix.UI.Windows
{
    public partial class AboutWindow : Window
    {
        public AboutWindow() : base($"Kaijinix {Program.Version} - About")
        {
            Icon = new Gdk.Pixbuf(Assembly.GetAssembly(typeof(OpenHelper)), "Kaijinix.UI.Common.Resources.Logo_Kaijinix.png");
            InitializeComponent();

            _ = DownloadPatronsJson();
        }

        private async Task DownloadPatronsJson()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                _patreonNamesText.Buffer.Text = "Connection Error.";
            }

            HttpClient httpClient = new();

            try
            {
                string patreonJsonString = await httpClient.GetStringAsync("https://patreon.Kaijinix.org/");

                _patreonNamesText.Buffer.Text = string.Join(", ", JsonHelper.Deserialize(patreonJsonString, CommonJsonContext.Default.StringArray));
            }
            catch
            {
                _patreonNamesText.Buffer.Text = "API Error.";
            }
        }

        //
        // Events
        //
        private void KaijinixButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://Kaijinix.org");
        }

        private void AmiiboApiButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://amiiboapi.com");
        }

        private void PatreonButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://www.patreon.com/Kaijinix");
        }

        private void GitHubButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://github.com/Kaijinix/Kaijinix");
        }

        private void DiscordButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://discordapp.com/invite/N2FmfVc");
        }

        private void TwitterButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://twitter.com/KaijinixEmu");
        }

        private void ContributorsButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://github.com/Kaijinix/Kaijinix/graphs/contributors?type=a");
        }

        private void ChangelogButton_Pressed(object sender, ButtonPressEventArgs args)
        {
            OpenHelper.OpenUrl("https://github.com/Kaijinix/Kaijinix/wiki/Changelog#Kaijinix-changelog");
        }
    }
}
