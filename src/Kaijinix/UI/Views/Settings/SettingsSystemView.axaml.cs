using Avalonia.Controls;
using Kaijinix.Ava.UI.ViewModels;
using Models_TimeZone = Kaijinix.Ava.UI.Models.TimeZone;
using TimeZone = Kaijinix.Ava.UI.Models.TimeZone;

namespace Kaijinix.Ava.UI.Views.Settings
{
    public partial class SettingsSystemView : UserControl
    {
        public SettingsViewModel ViewModel;

        public SettingsSystemView()
        {
            InitializeComponent();
        }

        private void TimeZoneBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null && e.AddedItems.Count > 0)
            {
                if (e.AddedItems[0] is Models_TimeZone timeZone)
                {
                    e.Handled = true;

                    ViewModel.ValidateAndSetTimeZone(timeZone.Location);
                }
            }
        }

        private void TimeZoneBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is AutoCompleteBox box && box.SelectedItem is Models_TimeZone timeZone)
            {
                ViewModel.ValidateAndSetTimeZone(timeZone.Location);
            }
        }
    }
}
