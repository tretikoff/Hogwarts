#if __ANDROID__
using Android.Content;
using Android.Runtime;
using Android.Text;
using Android.Widget;
#endif
using Qoden.UI;
using Qoden.UI.Wrappers;
using Button = Qoden.UI.Wrappers.Button;

namespace SignUp
{
    public class SignUpView : QodenView
    {
        public Button SignUp { get; }
        public TextField Login { get; }
        public TextField Password { get; }
        public TextField ConfirmPassword { get; }

        public SignUpView(Context context) : base(context)
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
            //my phone content area is 360x511dp

            var login = layout.View(Login)
                .Top(50.Dp())
                .AutoSize()
                .Width(200.Dp())
                .Left(80.Dp());

            var password = layout.View(Password)
                .Below(login, 50.Dp())
                .AutoSize()
                .Width(200.Dp())
                .Left(80.Dp());

            var confirmPassword = layout.View(ConfirmPassword)
                .Below(password, 5.Dp())
                .AutoSize()
                .Width(200.Dp())
                .Left(80.Dp());

            var signUp = layout.View(SignUp)
                .Bottom(30.Dp())
                .Height(60.Dp())
                .Width(180.Dp())
                .Left(90.Dp());

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