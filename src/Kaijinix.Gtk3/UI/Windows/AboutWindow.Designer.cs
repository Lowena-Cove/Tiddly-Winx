﻿using Gtk;
using Pango;
using Kaijinix.UI.Common.Configuration;
using System.Reflection;

namespace Kaijinix.UI.Windows
{
    public partial class AboutWindow : Window
    {
        private Box _mainBox;
        private Box _leftBox;
        private Box _logoBox;
        private Image _KaijinixLogo;
        private Box _logoTextBox;
        private Label _KaijinixLabel;
        private Label _KaijinixPhoneticLabel;
        private EventBox _KaijinixLink;
        private Label _KaijinixLinkLabel;
        private Label _versionLabel;
        private Label _disclaimerLabel;
        private EventBox _amiiboApiLink;
        private Label _amiiboApiLinkLabel;
        private Box _socialBox;
        private EventBox _patreonEventBox;
        private Box _patreonBox;
        private Image _patreonLogo;
        private Label _patreonLabel;
        private EventBox _githubEventBox;
        private Box _githubBox;
        private Image _githubLogo;
        private Label _githubLabel;
        private Box _discordBox;
        private EventBox _discordEventBox;
        private Image _discordLogo;
        private Label _discordLabel;
        private EventBox _twitterEventBox;
        private Box _twitterBox;
        private Image _twitterLogo;
        private Label _twitterLabel;
        private Separator _separator;
        private Box _rightBox;
        private Label _aboutLabel;
        private Label _aboutDescriptionLabel;
        private Label _createdByLabel;
        private TextView _createdByText;
        private EventBox _contributorsEventBox;
        private Label _contributorsLinkLabel;
        private Label _patreonNamesLabel;
        private ScrolledWindow _patreonNamesScrolled;
        private TextView _patreonNamesText;
        private EventBox _changelogEventBox;
        private Label _changelogLinkLabel;

        private void InitializeComponent()
        {

            //
            // AboutWindow
            //
            CanFocus = false;
            Resizable = false;
            Modal = true;
            WindowPosition = WindowPosition.Center;
            DefaultWidth = 800;
            DefaultHeight = 450;
            TypeHint = Gdk.WindowTypeHint.Dialog;

            //
            // _mainBox
            //
            _mainBox = new Box(Orientation.Horizontal, 0);

            //
            // _leftBox
            //
            _leftBox = new Box(Orientation.Vertical, 0)
            {
                Margin = 15,
                MarginStart = 30,
                MarginEnd = 0,
            };

            //
            // _logoBox
            //
            _logoBox = new Box(Orientation.Horizontal, 0);

            //
            // _KaijinixLogo
            //
            _KaijinixLogo = new Image(new Gdk.Pixbuf(Assembly.GetAssembly(typeof(ConfigurationState)), "Kaijinix.UI.Common.Resources.Logo_Kaijinix.png", 100, 100))
            {
                Margin = 10,
                MarginStart = 15,
            };

            //
            // _logoTextBox
            //
            _logoTextBox = new Box(Orientation.Vertical, 0);

            //
            // _KaijinixLabel
            //
            _KaijinixLabel = new Label("Kaijinix")
            {
                MarginTop = 15,
                Justify = Justification.Center,
                Attributes = new AttrList(),
            };
            _KaijinixLabel.Attributes.Insert(new Pango.AttrScale(2.7f));

            //
            // _KaijinixPhoneticLabel
            //
            _KaijinixPhoneticLabel = new Label("(REE-YOU-JINX)")
            {
                Justify = Justification.Center,
            };

            //
            // _KaijinixLink
            //
            _KaijinixLink = new EventBox()
            {
                Margin = 5
            };
            _KaijinixLink.ButtonPressEvent += KaijinixButton_Pressed;

            //
            // _KaijinixLinkLabel
            //
            _KaijinixLinkLabel = new Label("www.Kaijinix.org")
            {
                TooltipText = "Click to open the Kaijinix website in your default browser.",
                Justify = Justification.Center,
                Attributes = new AttrList(),
            };
            _KaijinixLinkLabel.Attributes.Insert(new Pango.AttrUnderline(Underline.Single));

            //
            // _versionLabel
            //
            _versionLabel = new Label(Program.Version)
            {
                Expand = true,
                Justify = Justification.Center,
                Margin = 5,
            };

            //
            // _changelogEventBox
            //
            _changelogEventBox = new EventBox();
            _changelogEventBox.ButtonPressEvent += ChangelogButton_Pressed;

            //
            // _changelogLinkLabel
            //
            _changelogLinkLabel = new Label("View Changelog on GitHub")
            {
                TooltipText = "Click to open the changelog for this version in your default browser.",
                Justify = Justification.Center,
                Attributes = new AttrList(),
            };
            _changelogLinkLabel.Attributes.Insert(new Pango.AttrUnderline(Underline.Single));

            //
            // _disclaimerLabel
            //
            _disclaimerLabel = new Label("Kaijinix is not affiliated with Nintendo™,\nor any of its partners, in any way.")
            {
                Expand = true,
                Justify = Justification.Center,
                Margin = 5,
                Attributes = new AttrList(),
            };
            _disclaimerLabel.Attributes.Insert(new Pango.AttrScale(0.8f));

            //
            // _amiiboApiLink
            //
            _amiiboApiLink = new EventBox()
            {
                Margin = 5,
            };
            _amiiboApiLink.ButtonPressEvent += AmiiboApiButton_Pressed;

            //
            // _amiiboApiLinkLabel
            //
            _amiiboApiLinkLabel = new Label("AmiiboAPI (www.amiiboapi.com) is used\nin our Amiibo emulation.")
            {
                TooltipText = "Click to open the AmiiboAPI website in your default browser.",
                Justify = Justification.Center,
                Attributes = new AttrList(),
            };
            _amiiboApiLinkLabel.Attributes.Insert(new Pango.AttrScale(0.9f));

            //
            // _socialBox
            //
            _socialBox = new Box(Orientation.Horizontal, 0)
            {
                Margin = 25,
                MarginBottom = 10,
            };

            //
            // _patreonEventBox
            //
            _patreonEventBox = new EventBox()
            {
                TooltipText = "Click to open the Kaijinix Patreon page in your default browser.",
            };
            _patreonEventBox.ButtonPressEvent += PatreonButton_Pressed;

            //
            // _patreonBox
            //
            _patreonBox = new Box(Orientation.Vertical, 0);

            //
            // _patreonLogo
            //
            _patreonLogo = new Image(new Gdk.Pixbuf(Assembly.GetAssembly(typeof(ConfigurationState)), "Kaijinix.UI.Common.Resources.Logo_Patreon_Light.png", 30, 30))
            {
                Margin = 10,
            };

            //
            // _patreonLabel
            //
            _patreonLabel = new Label("Patreon")
            {
                Justify = Justification.Center,
            };

            //
            // _githubEventBox
            //
            _githubEventBox = new EventBox()
            {
                TooltipText = "Click to open the Kaijinix GitHub page in your default browser.",
            };
            _githubEventBox.ButtonPressEvent += GitHubButton_Pressed;

            //
            // _githubBox
            //
            _githubBox = new Box(Orientation.Vertical, 0);

            //
            // _githubLogo
            //
            _githubLogo = new Image(new Gdk.Pixbuf(Assembly.GetAssembly(typeof(ConfigurationState)), "Kaijinix.UI.Common.Resources.Logo_GitHub_Light.png", 30, 30))
            {
                Margin = 10,
            };

            //
            // _githubLabel
            //
            _githubLabel = new Label("GitHub")
            {
                Justify = Justification.Center,
            };

            //
            // _discordBox
            //
            _discordBox = new Box(Orientation.Vertical, 0);

            //
            // _discordEventBox
            //
            _discordEventBox = new EventBox()
            {
                TooltipText = "Click to open an invite to the Kaijinix Discord server in your default browser.",
            };
            _discordEventBox.ButtonPressEvent += DiscordButton_Pressed;

            //
            // _discordLogo
            //
            _discordLogo = new Image(new Gdk.Pixbuf(Assembly.GetAssembly(typeof(ConfigurationState)), "Kaijinix.UI.Common.Resources.Logo_Discord_Light.png", 30, 30))
            {
                Margin = 10,
            };

            //
            // _discordLabel
            //
            _discordLabel = new Label("Discord")
            {
                Justify = Justification.Center,
            };

            //
            // _twitterEventBox
            //
            _twitterEventBox = new EventBox()
            {
                TooltipText = "Click to open the Kaijinix Twitter page in your default browser.",
            };
            _twitterEventBox.ButtonPressEvent += TwitterButton_Pressed;

            //
            // _twitterBox
            //
            _twitterBox = new Box(Orientation.Vertical, 0);

            //
            // _twitterLogo
            //
            _twitterLogo = new Image(new Gdk.Pixbuf(Assembly.GetAssembly(typeof(ConfigurationState)), "Kaijinix.UI.Common.Resources.Logo_Twitter_Light.png", 30, 30))
            {
                Margin = 10,
            };

            //
            // _twitterLabel
            //
            _twitterLabel = new Label("Twitter")
            {
                Justify = Justification.Center,
            };

            //
            // _separator
            //
            _separator = new Separator(Orientation.Vertical)
            {
                Margin = 15,
            };

            //
            // _rightBox
            //
            _rightBox = new Box(Orientation.Vertical, 0)
            {
                Margin = 15,
                MarginTop = 40,
            };

            //
            // _aboutLabel
            //
            _aboutLabel = new Label("About :")
            {
                Halign = Align.Start,
                Attributes = new AttrList(),
            };
            _aboutLabel.Attributes.Insert(new Pango.AttrWeight(Weight.Bold));
            _aboutLabel.Attributes.Insert(new Pango.AttrUnderline(Underline.Single));

            //
            // _aboutDescriptionLabel
            //
            _aboutDescriptionLabel = new Label("Kaijinix is an emulator for the Nintendo Switch™.\n" +
                                               "Please support us on Patreon.\n" +
                                               "Get all the latest news on our Twitter or Discord.\n" +
                                               "Developers interested in contributing can find out more on our GitHub or Discord.")
            {
                Margin = 15,
                Halign = Align.Start,
            };

            //
            // _createdByLabel
            //
            _createdByLabel = new Label("Maintained by :")
            {
                Halign = Align.Start,
                Attributes = new AttrList(),
            };
            _createdByLabel.Attributes.Insert(new Pango.AttrWeight(Weight.Bold));
            _createdByLabel.Attributes.Insert(new Pango.AttrUnderline(Underline.Single));

            //
            // _createdByText
            //
            _createdByText = new TextView()
            {
                WrapMode = Gtk.WrapMode.Word,
                Editable = false,
                CursorVisible = false,
                Margin = 15,
                MarginEnd = 30,
            };
            _createdByText.Buffer.Text = "gdkchan, Ac_K, Thog, rip in peri peri, LDj3SNuD, emmaus, Thealexbarney, Xpl0itR, GoffyDude, »jD« and more...";

            //
            // _contributorsEventBox
            //
            _contributorsEventBox = new EventBox();
            _contributorsEventBox.ButtonPressEvent += ContributorsButton_Pressed;

            //
            // _contributorsLinkLabel
            //
            _contributorsLinkLabel = new Label("See All Contributors...")
            {
                TooltipText = "Click to open the Contributors page in your default browser.",
                MarginEnd = 30,
                Halign = Align.End,
                Attributes = new AttrList(),
            };
            _contributorsLinkLabel.Attributes.Insert(new Pango.AttrUnderline(Underline.Single));

            //
            // _patreonNamesLabel
            //
            _patreonNamesLabel = new Label("Supported on Patreon by :")
            {
                Halign = Align.Start,
                Attributes = new AttrList(),
            };
            _patreonNamesLabel.Attributes.Insert(new Pango.AttrWeight(Weight.Bold));
            _patreonNamesLabel.Attributes.Insert(new Pango.AttrUnderline(Underline.Single));

            //
            // _patreonNamesScrolled
            //
            _patreonNamesScrolled = new ScrolledWindow()
            {
                Margin = 15,
                MarginEnd = 30,
                Expand = true,
                ShadowType = ShadowType.In,
            };
            _patreonNamesScrolled.SetPolicy(PolicyType.Never, PolicyType.Automatic);

            //
            // _patreonNamesText
            //
            _patreonNamesText = new TextView()
            {
                WrapMode = Gtk.WrapMode.Word,
            };
            _patreonNamesText.Buffer.Text = "Loading...";
            _patreonNamesText.SetProperty("editable", new GLib.Value(false));

            ShowComponent();
        }

        private void ShowComponent()
        {
            _logoBox.Add(_KaijinixLogo);

            _KaijinixLink.Add(_KaijinixLinkLabel);

            _logoTextBox.Add(_KaijinixLabel);
            _logoTextBox.Add(_KaijinixPhoneticLabel);
            _logoTextBox.Add(_KaijinixLink);

            _logoBox.Add(_logoTextBox);

            _amiiboApiLink.Add(_amiiboApiLinkLabel);

            _patreonBox.Add(_patreonLogo);
            _patreonBox.Add(_patreonLabel);
            _patreonEventBox.Add(_patreonBox);

            _githubBox.Add(_githubLogo);
            _githubBox.Add(_githubLabel);
            _githubEventBox.Add(_githubBox);

            _discordBox.Add(_discordLogo);
            _discordBox.Add(_discordLabel);
            _discordEventBox.Add(_discordBox);

            _twitterBox.Add(_twitterLogo);
            _twitterBox.Add(_twitterLabel);
            _twitterEventBox.Add(_twitterBox);

            _socialBox.Add(_patreonEventBox);
            _socialBox.Add(_githubEventBox);
            _socialBox.Add(_discordEventBox);
            _socialBox.Add(_twitterEventBox);

            _changelogEventBox.Add(_changelogLinkLabel);

            _leftBox.Add(_logoBox);
            _leftBox.Add(_versionLabel);
            _leftBox.Add(_changelogEventBox);
            _leftBox.Add(_disclaimerLabel);
            _leftBox.Add(_amiiboApiLink);
            _leftBox.Add(_socialBox);

            _contributorsEventBox.Add(_contributorsLinkLabel);
            _patreonNamesScrolled.Add(_patreonNamesText);

            _rightBox.Add(_aboutLabel);
            _rightBox.Add(_aboutDescriptionLabel);
            _rightBox.Add(_createdByLabel);
            _rightBox.Add(_createdByText);
            _rightBox.Add(_contributorsEventBox);
            _rightBox.Add(_patreonNamesLabel);
            _rightBox.Add(_patreonNamesScrolled);

            _mainBox.Add(_leftBox);
            _mainBox.Add(_separator);
            _mainBox.Add(_rightBox);

            Add(_mainBox);

            ShowAll();
        }
    }
}
