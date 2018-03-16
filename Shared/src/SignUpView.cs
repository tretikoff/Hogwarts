using Android.OS;
using Qoden.UI;
using Qoden.UI.Wrappers;
using Button = Qoden.UI.Wrappers.Button;
#if __ANDROID__
using Android.Content;
using Android.Text;

#endif


namespace SignUp
{
    public class SignUpView : QodenView
    {
        public Button SignUp { get; }
        public TextField Login { get; }
        public TextField Password { get; }
        public TextField ConfirmPassword { get; }

        public Label ConfirmPasswordInfo { get; }
        public Label PasswordInfo { get; }
        public Label LoginInfo { get; }

#if __IOS__
        public SignUpView()
#endif
#if __ANDROID__
        public SignUpView(Context context) : base(context)
#endif
        {
            Login = Builder.TextField();
            Login.SetHint("Login");

            Password = Builder.TextField();
            Password.SetHint("Password");

            ConfirmPassword = Builder.TextField();
            ConfirmPassword.SetHint("Confirm Password");

            SignUp = Builder.Button();
            SignUp.SetText("Sign up");

            LoginInfo = Builder.Label();
            LoginInfo.SetText("Login must be at least 3 characters");

            PasswordInfo = Builder.Label();
            PasswordInfo.SetText("Password must be at least 6 characters");
            ConfirmPasswordInfo = Builder.Label();


#if __ANDROID__
            Login.PlatformView.InputType =
                InputTypes.TextVariationVisiblePassword | InputTypes.TextFlagNoSuggestions;

            //show dots instead of symbols
            Password.PlatformView.InputType =
                InputTypes.TextVariationPassword | InputTypes.ClassText;

            ConfirmPassword.PlatformView.InputType =
                InputTypes.TextVariationPassword | InputTypes.ClassText;

            if (Build.VERSION.SdkInt < BuildVersionCodes.M)
            {
                LoginInfo.PlatformView.SetTextAppearance(Context, Resource.Style
                    .TextAppearance_AppCompat_Caption);
                PasswordInfo.PlatformView.SetTextAppearance(Context, Resource.Style
                    .TextAppearance_AppCompat_Caption);
                ConfirmPasswordInfo.PlatformView.SetTextAppearance(Context, Resource.Style
                    .TextAppearance_AppCompat_Caption);
            }
            else
            {
                LoginInfo.PlatformView.SetTextAppearance(Resource.Style
                    .TextAppearance_AppCompat_Caption);
                PasswordInfo.PlatformView.SetTextAppearance(Resource.Style
                    .TextAppearance_AppCompat_Caption);
                ConfirmPasswordInfo.PlatformView.SetTextAppearance(Resource.Style
                    .TextAppearance_AppCompat_Caption);
            }
#endif
        }

        protected override void OnLayout(LayoutBuilder layout)
        {
            var outerBounds = layout.PaddedOuterBounds;

            var login = layout.View(Login)
                .Top(outerBounds.Bottom * 0.1f)
                .AutoSize()
                .Width(200.Dp())
                .CenterHorizontally();
            var loginInfo = layout.View(LoginInfo)
                .Below(login)
                .MaxWidth(login.Width)
                .AutoSize()
                .CenterHorizontally();

            var password = layout.View(Password)
                .Below(login, outerBounds.Bottom * 0.1f)
                .AutoSize()
                .MinWidth(200.Dp())
                .CenterHorizontally();
            var passwordInfo = layout.View(PasswordInfo)
                .Below(password)
                .MaxWidth(password.Width)
                .AutoSize()
                .CenterHorizontally();

            var confirmPassword = layout.View(ConfirmPassword)
                .Below(passwordInfo, 5.Dp())
                .AutoSize()
                .MinWidth(200.Dp())
                .CenterHorizontally();
            var confirmPasswordInfo = layout.View(ConfirmPasswordInfo)
                .Below(confirmPassword)
                .MaxWidth(confirmPassword.Width)
                .AutoSize()
                .CenterHorizontally();

            var signUpHeight = 60.Dp();
            var signUp = layout.View(SignUp)
                .Height(signUpHeight)
                .Width(180.Dp())
                .Top(confirmPassword.Bottom +
                     (outerBounds.Bottom - confirmPassword.Bottom) * 0.95f - signUpHeight)
                .CenterHorizontally();
        }
    }
}