using System.ComponentModel;
using Qoden.Binding;
using Qoden.UI;

namespace SignUp
{
    public class SignUpController : QodenController<SignUpView>
    {
        private SignUpModel _model;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _model = this.GetViewModelStore().Get(() => new SignUpModel());

            Bindings.Command(_model.SignUpCommand)
                .To(View.SignUp.ClickTarget());

            Bindings.Property(_model, x => x.Login)
                .To(View.Login.TextProperty());

            Bindings.Property(_model, x => x.Password)
                .To(View.Password.TextProperty());

            Bindings.Property(_model, x => x.ConfirmPassword)
                .To(View.ConfirmPassword.TextProperty());

            Bindings.Command(
                    new Command
                    {
                        Action = PerformSignUp
                    })
                .To(View.SignUp.ClickTarget());
        }

        void PerformSignUp(object obj)
        {
            if (SignUpContext.UserStorageService.UserExists(_model.Login))
            {

                View.ErrorMessageLabel.SetText("Current login is already in use");
            }
            else
            {
                _model.PerformSignUp(obj);
                View.ErrorMessageLabel.SetText("");
            }
        }
    }
}