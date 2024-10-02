using Gtk;
using Kaijinix.UI.Common.Configuration;
using System.Reflection;

namespace Kaijinix.UI.Applet
{
    internal class ErrorAppletDialog : MessageDialog
    {
        public ErrorAppletDialog(Window parentWindow, DialogFlags dialogFlags, MessageType messageType, string[] buttons) : base(parentWindow, dialogFlags, messageType, ButtonsType.None, null)
        {
            Icon = new Gdk.Pixbuf(Assembly.GetAssembly(typeof(ConfigurationState)), "Kaijinix.Gtk3.UI.Common.Resources.Logo_Kaijinix.png");

            int responseId = 0;

            if (buttons != null)
            {
                foreach (string buttonText in buttons)
                {
                    AddButton(buttonText, responseId);
                    responseId++;
                }
            }
            else
            {
                AddButton("OK", 0);
            }

            ShowAll();
        }
    }
}
