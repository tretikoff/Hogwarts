using Android.App;
using Android.Widget;
using Android.OS;
using Button = Android.Widget.Button;

namespace Droid
{
    [Activity(Label = "Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (new Button(this));
        }
    }
}