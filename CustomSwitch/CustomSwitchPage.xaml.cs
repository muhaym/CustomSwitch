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

        void Handle_CustomToggled(object sender, CustomToggledEventArgs e)
        {
            DisplayAlert("Switch Control", (e.IsUser ? "I'm User" : "I'm program") + "& my value is " + e.Value, "Okay");
        }

        public CustomSwitchPage()
        {
            InitializeComponent();
        }


    }
}
