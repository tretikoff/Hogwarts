using System;
using Android;
using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace SignUp
{
    [Activity(
        Label = "Sign Up",
        MainLauncher = true,
        Icon = "@drawable/icon",
        Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
    public class MainActivity : AppCompatActivity
    {
        private SignUpController SignUpController;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            SignUpController = new SignUpController();

            SupportFragmentManager.BeginTransaction()
                .Add(Resource.Id.content_frame, SignUpController)
                .Commit();
        }
    }
}