
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace ButterfliesXFPrism.Droid
{
    [Activity(Label = "Butterfly", MainLauncher = true, NoHistory = true, Theme = "@style/MyTheme.Splash",
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}