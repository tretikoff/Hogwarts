using Qoden.UI;
using Qoden.UI.Wrappers;
using Button = Qoden.UI.Wrappers.Button;
#if __ANDROID__
using Android.Content;
using Android.Runtime;
using Android.Text;
using Android.Widget;

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
        }

        protected override void OnLayout(LayoutBuilder layout)
        {
            var login = layout.View(Login)
                .Top(50.Dp())
                .AutoSize()
                .Width(200.Dp())
                .CenterHorizontally();

            var password = layout.View(Password)
                .Below(login, 50.Dp())
                .AutoSize()
                .MinWidth(200.Dp())
                .CenterHorizontally();

            var confirmPassword = layout.View(ConfirmPassword)
                .Below(password, 5.Dp())
                .AutoSize()
                .MinWidth(200.Dp())
                .CenterHorizontally();

            var signUp = layout.View(SignUp)
                .Bottom(30.Dp())
                .Height(60.Dp())
                .Width(180.Dp())
                .CenterHorizontally();

#if __ANDROID__
            var loginPlatformView = Login.AsView().PlatformView.JavaCast<EditText>();
            loginPlatformView.InputType =
                InputTypes.TextVariationVisiblePassword | InputTypes.TextFlagNoSuggestions;

            var passwordPlatformView = Password.AsView().PlatformView.JavaCast<EditText>();
            passwordPlatformView.InputType =
                InputTypes.TextVariationPassword | InputTypes.ClassText;

            var confirmPasswordPlatformView =
                ConfirmPassword.AsView().PlatformView.JavaCast<EditText>();
            confirmPasswordPlatformView.InputType =
                InputTypes.TextVariationPassword | InputTypes.ClassText;
#endif
        }
    }
}