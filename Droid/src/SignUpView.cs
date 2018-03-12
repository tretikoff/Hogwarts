using System;
using Android.Content;
using Qoden.UI;
using Qoden.UI.Wrappers;

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
            var login = layout.View(Login)
                .Top(60.Dp())
                .AutoSize(maxWidth: 200.Dp(), maxHeight: 60.Dp())
                .MinWidth(150.Dp())
                .Left(100.Dp());

            var password = layout.View(Password)
                .Below(login, 30.Dp())
                .AutoSize(maxWidth: 200.Dp(), maxHeight: 60.Dp())
                .MinWidth(150.Dp())
                .Left(100.Dp());

            var confirmPassword = layout.View(ConfirmPassword)
                .Below(password, 10.Dp())
                .AutoSize(maxWidth: 200.Dp(), maxHeight: 60.Dp())
                .MinWidth(160.Dp())
                .Left(100.Dp());

            Console.WriteLine(confirmPassword.OuterBounds.Width.Dp());

            var signUp = layout.View(SignUp)
                .Bottom(30.Dp())
                .Height(60.Dp())
                .Width(180.Dp())
                .Left(90.Dp());
        }
    }
}