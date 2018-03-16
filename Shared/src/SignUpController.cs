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
                .To(View.Password.TextProperty())
                .AfterUpdate(DisplayConfirmPasswordError);

            Bindings.Property(_model, x => x.ConfirmPassword)
                .To(View.ConfirmPassword.TextProperty())
                .AfterUpdate(DisplayConfirmPasswordError);
        }

        private void DisplayConfirmPasswordError(IPropertyBinding binding,
            ChangeSource changesource)
        {
            if (_model.ConfirmPassword != null && !_model.ConfirmPassword.Equals(_model.Password))
            {
                View.ConfirmPasswordInfo.SetText("Passwords must be equal");
            }
            else
            {
                View.ConfirmPasswordInfo.SetText("");
            }
        }
    }
}