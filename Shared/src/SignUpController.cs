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

            Bindings.Property(_model, x => x.Login)
                .To(View.Login.TextProperty())
                .AfterUpdate((binding, source) =>
                {
                    binding.UpdateSource();

                });

            Bindings.Property(_model, x => x.Password)
                .To(View.Password.TextProperty())
                .OneWayToSource();

            Bindings.Property(_model, x => x.ConfirmPassword)
                .To(View.ConfirmPassword.TextProperty())
                .OneWayToSource();

            Bindings.Command(_model.SignUpCommand)
                .To(View.SignUp.ClickTarget());

            Bindings.Bind();
        }
    }
}