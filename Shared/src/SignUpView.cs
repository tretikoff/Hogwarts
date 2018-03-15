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

#if __IOS__
        public SignUpView()
#endif
#if __ANDROID__
        public SignUpView(Context context) : base(context)
#endif
        {
            SignUp = Builder.Button();
            SignUp.SetText("Sign up");

            Login = Builder.TextField();
            Login.SetHint("Login");

            Password = Builder.TextField();
            Password.SetHint("Password");

            ConfirmPassword = Builder.TextField();
            ConfirmPassword.SetHint("Confirm Password");

#if __ANDROID__
            Login.PlatformView.InputType =
                InputTypes.TextVariationVisiblePassword | InputTypes.TextFlagNoSuggestions;

            //show dots instead of symbols
            Password.PlatformView.InputType =
                InputTypes.TextVariationPassword | InputTypes.ClassText;

            ConfirmPassword.PlatformView.InputType =
                InputTypes.TextVariationPassword | InputTypes.ClassText;
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

            var password = layout.View(Password)
                .Below(login, outerBounds.Bottom * 0.1f)
                .AutoSize()
                .MinWidth(200.Dp())
                .CenterHorizontally();

            var confirmPassword = layout.View(ConfirmPassword)
                .Below(password, 5.Dp())
                .AutoSize()
                .MinWidth(200.Dp())
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