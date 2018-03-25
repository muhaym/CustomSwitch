using Xamarin.Forms;

namespace CustomSwitch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomSwitchPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
