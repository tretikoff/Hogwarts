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
    public class SignUpActivity : AppCompatActivity
    {
        private SignUpController _signUpController;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            _signUpController = new SignUpController();

            SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.content_frame, _signUpController)
//                .Add(Resource.Id.content_frame, _signUpController)
                .Commit();
        }
    }
}