using System;
using Xamarin.Forms;

namespace CustomSwitch
{
    public partial class CustomSwitchPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            custom.IsCustomToggled = !custom.IsCustomToggled;
        }

        public CustomSwitchPage()
        {
            InitializeComponent();
            //switchee.Toggled += Switche_toggled;
            custom.CustomToggled += thenga;
        }

        //private void Switche_toggled(object sender, ToggledEventArgs e)
        //{
        //    var val = switchee.IsToggled;
        //}
        private void thenga(object sender, CustomToggledEventArgs e)
        {
            var val = custom.IsCustomToggled;
            DisplayAlert("Switch Control", (e.IsUser ? "I'm User" : "I'm program") + "& my value is " + e.Value, "Okay");
        }
    }
}
