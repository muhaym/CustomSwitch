using System;
using Xamarin.Forms;

namespace CustomSwitch
{
    public class CustomToggledEventArgs : EventArgs
    {
        public CustomToggledEventArgs(bool value, bool isuser)
        {
            Value = value;
            IsUser = isuser;
        }

        public bool Value { get; private set; }
        public bool IsUser { get; private set; }
    }


    public class CustomSwitch : Switch
    {
        private bool isUser { get; set; } = true;
        public bool IsCustomToggled
        {
            get => IsToggled;
            set
            {
                //The Order of Code is Very Important, We are removing Event Handler from Original Switch
                this.Toggled -= Handle_Toggled;
                //Setting IsToggled with IsCustomToggled
                IsToggled = value;
                //Invoking Custom Event with is User Property
                CustomToggled?.Invoke(this, new CustomToggledEventArgs(IsToggled, false));
                //Enabling Event again
                this.Toggled += Handle_Toggled;
            }
        }

        public static readonly BindableProperty IsCustomToggledProperty = BindableProperty.Create("IsCustomToggled", typeof(bool), typeof(CustomSwitch), false, BindingMode.TwoWay);

        public event EventHandler<CustomToggledEventArgs> CustomToggled;


        public CustomSwitch()
        {
            //Subscribing to the original event
            this.Toggled += Handle_Toggled;
        }

        private void Handle_Toggled(object sender, ToggledEventArgs e)
        {
            //This even only fires when user is changing switch
            CustomToggled?.Invoke(this, new CustomToggledEventArgs(IsToggled, true));
        }
    }
}
