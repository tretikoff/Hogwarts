using System;
using Proveo.Model;
using Qoden.Auth;
using Qoden.Binding;
using Qoden.UI;
using Qoden.UI.Wrappers;

#if __ANDROID__
using Android.Content;
#endif

namespace Proveo
{
    public class LoginView : QodenView
    {
#if __IOS__
        public LoginView()
#endif
#if __ANDROID__
        public LoginView(Context ctx) : base(ctx)
#endif
        {
            Login = Builder.Button();
            Login.SetText(L10n.Localize("LoginButton"));
            Login.SetTextColor(new RGB(255, 0, 0));

            Logout = Builder.Button();
            Logout.SetText(L10n.Localize("LogoutButton"));
            Logout.SetTextColor(new RGB(255, 0, 0));

            IdToken = Builder.Label();
            IdToken.SetTextColor(new RGB(0, 255, 0));
        }

        public Button Login { get; }

        public Button Logout { get; }

        public Label IdToken { get; }

        protected override void OnLayout(LayoutBuilder layout)
        {
            var login = layout.View(Login)
                              .Top(10.Dp())
                              .CenterHorizontally()
                              .AutoSize();

            var logout = layout.View(Logout)
                               .Below(login, 5.Dp())
                               .CenterHorizontally()
                               .AutoSize();

            layout.View(IdToken)
                  .Below(logout, 5.Dp())
                  .Left(0)
                  .Right(0)
                  .Bottom(0);
        }
    }

    public class LoginController : QodenController<LoginView>
    {
        Command LoginCommand;
        Command LogoutCommand;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            LoginCommand = new Command
            {
                Action = Login
            };

            LogoutCommand = new Command
            {
                Action = Logout
            };

            Bindings.Command(LoginCommand).To(View.Login.PlatformView.ClickTarget());
            Bindings.Command(LogoutCommand).To(View.Logout.PlatformView.ClickTarget());

            View.IdToken.SetText(L10n.Localize("EmptyIdTokenHint"));

#if __IOS__
            View.IdToken.PlatformView.LineBreakMode = UIKit.UILineBreakMode.WordWrap;
            View.IdToken.PlatformView.Lines = 0;
#endif
            View.AsView().SetBackgroundColor(Theme.Colors.BG);
        }

        void Logout(object obj)
        {
            ProveoContext.Principal.SecureStore.Delete(ProveoContext.Principal.ProfileKey);
        }

        async void Login(object obj)
        {
            try
            {
                var user = await ProveoContext.Principal.Authenticate(true);
                var idToken = user[OAuthApi.IdToken] as string;
                View.IdToken.SetText(idToken);
            }
            catch (Exception e)
            {
                View.IdToken.SetText(e.Message);
            }
        }
    }
}
