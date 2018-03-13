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

            var signUpCommandBinding = new CommandBinding
            {
                Command = _model.SignUpCommand,
                Trigger = View.SignUp.ClickTarget()
            };

            void UpdateSourceAndCommand(IPropertyBinding binding, ChangeSource source)
            {
                binding.UpdateSource();
                signUpCommandBinding.UpdateTarget();
            }

            //doesn't update button state
            Bindings.Command(_model.SignUpCommand)
                .To(View.SignUp.ClickTarget());

            Bindings.Property(_model, x => x.Login)
                .To(View.Login.TextProperty())
                .AfterTargetUpdate(UpdateSourceAndCommand);

            Bindings.Property(_model, x => x.Password)
                .To(View.Password.TextProperty())
                .AfterTargetUpdate(UpdateSourceAndCommand);

            Bindings.Property(_model, x => x.ConfirmPassword)
                .To(View.ConfirmPassword.TextProperty())
                .AfterTargetUpdate(UpdateSourceAndCommand);

            Bindings.Bind();
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
            Bindings.Unbind();
        }
    }
}